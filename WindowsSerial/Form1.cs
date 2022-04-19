using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

/// <summary>
/// Автор программы: Кобелева В.О.
/// Версия: 1.0
/// Дата версии: 07.04.2022
/// 
/// Дата передачи: 07.04.2022
/// Соавтор: Бовкун Е.А.
/// Версия 1.1
/// Дата версии: 
/// /// </summary>

namespace WindowsSerial
{
	public partial class Form1 : Form
	{
		private SerialPort serial;
		private bool boundTest = false;
		private bool databitsTest = false;
		private bool isBoundrateCorrect = false;
		private bool isDatabitsCorrect = false;

		public Form1()
		{
			InitializeComponent();
			serial = new SerialPort(); //экзмепляр класса последовательного порта
			serial.DataReceived += OnReceived; //добавляем обработчик событий при получении данных
			UpdateComportNames();
		}

		private void connectButton_Click(object sender, EventArgs e)
		{
			if (serial.IsOpen) //если порт открыт
			{
				serial.Close();
				Console.WriteLine("Закрыто");
				connectButton.Text = "Connect";
				//SendCommandButton.Enabled = false; //делаем кнопку отправки команды доступной
			}
			else
			{
				connectButton.Text = "Disconnect";
				//устанавливаем параметры передачи данных
				serial.BaudRate = 9600;
				serial.DtrEnable = true; //терминал готов к передаче
				serial.DataBits = 8;
				serial.PortName = (string)comPortscomboBox.SelectedItem;
				boundTest = false; //тест на BoundRate не закончен
				databitsTest = false; //тест на DataBits не закончен
				isBoundrateCorrect = false; //статус теста - завален
				isDatabitsCorrect = false;
				serial.Open();
				serial.DiscardInBuffer(); //очистить буфер входных данных
				Console.WriteLine("Открыто");
			}
		}

		private void OnReceived(object sender, SerialDataReceivedEventArgs e)
		{
			if (!boundTest) //если не завершен boundTest
			{
				int recivedByte = serial.ReadByte();
				boundTest = true;
				if (recivedByte == 1)
				{
					isBoundrateCorrect = true;
					Console.WriteLine("Boundrate good");
				}
				else
				{
					Console.WriteLine("Boundrate bad");
				}
			}
			else if (!databitsTest) //если не завершен databitsTest
			{
				int recivedByte = serial.ReadByte();
				databitsTest = true;
				if (recivedByte == 255)
				{
					isDatabitsCorrect = true;
					Console.WriteLine("Databits good");
					//SendCommandButton.Enabled = true; //делаем кнопку отправки команды доступной
				}
				else
				{
					Console.WriteLine("Databits bad");
				}
			}
			else if (isBoundrateCorrect && isDatabitsCorrect) //если успешно пройдены все тесты, принимаем данные
			{
				String recivedMessage = serial.ReadLine();
				recivedMessage = recivedMessage.Replace("\r", "").Replace("\n", "");
				if (recivedMessage.StartsWith("temp:"))
				{
					ToLabelTemp(recivedMessage.Replace("temp:",""));
				}
				else
				{
					String[] partsOfMessage = recivedMessage.Split(':');
					try
					{
						ToAnswerTextBox(partsOfMessage[1]);
					}
					catch (Exception)
					{
						ToAnswerTextBox(recivedMessage);
					}
				}
			}
		}
		private void ToLabelTemp(string text) //функция изменения содержимого Label
		{
			if (InvokeRequired)
				Invoke((Action<string>)ToLabelTemp, text);
			else
				labelTemp.Text = text;
		}

		private void ToAnswerTextBox(string text) //функция изменения содержимого AnswerTextBox
		{
			if (InvokeRequired)
				Invoke((Action<string>)ToAnswerTextBox, text);
			else
				AnswerTextBox.Text = text;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			serial.Close();
		}

		private int UpdateComportNames()
		{
			comPortscomboBox.Items.Clear();
			// Получаем список COM портов доступных в системе
			string[] portnames = SerialPort.GetPortNames();
			// Проверяем есть ли доступные
			if (portnames.Length == 0)
			{
				MessageBox.Show("COM PORT not found");
			}

			foreach (string portName in portnames)
			{
				//добавляем доступные COM порты в список           
				comPortscomboBox.Items.Add(portName);
				Console.WriteLine(portnames.Length);
			}
			if (portnames.Length != 0)
			{
				comPortscomboBox.SelectedItem = portnames[0];
			}
			return (portnames.Length);
		}

		private void UpdatePortsButton_Click(object sender, EventArgs e)
		{
			UpdateComportNames();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void SendCommandButton_Click(object sender, EventArgs e)
		{
			string InputCommand = CommandTextBox.Text;
			if (isBoundrateCorrect && isDatabitsCorrect)
			{
				WriteData(InputCommand);
			}
		}
		private void WriteData (string data)
		{
			serial.WriteLine(data);
		}
	}
}
