
namespace WindowsSerial
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.comPortscomboBox = new System.Windows.Forms.ComboBox();
			this.connectButton = new System.Windows.Forms.Button();
			this.labelTemp = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.UpdatePortsButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.AnswerTextBox = new System.Windows.Forms.TextBox();
			this.CommandTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SendCommandButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// comPortscomboBox
			// 
			this.comPortscomboBox.FormattingEnabled = true;
			this.comPortscomboBox.Location = new System.Drawing.Point(57, 53);
			this.comPortscomboBox.Name = "comPortscomboBox";
			this.comPortscomboBox.Size = new System.Drawing.Size(121, 24);
			this.comPortscomboBox.TabIndex = 0;
			// 
			// connectButton
			// 
			this.connectButton.Location = new System.Drawing.Point(57, 126);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(121, 24);
			this.connectButton.TabIndex = 1;
			this.connectButton.Text = "Connect";
			this.connectButton.UseVisualStyleBackColor = true;
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// labelTemp
			// 
			this.labelTemp.AutoSize = true;
			this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTemp.Location = new System.Drawing.Point(257, 219);
			this.labelTemp.Name = "labelTemp";
			this.labelTemp.Size = new System.Drawing.Size(27, 29);
			this.labelTemp.TabIndex = 2;
			this.labelTemp.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Выбор доступного порта";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.UpdatePortsButton);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comPortscomboBox);
			this.groupBox1.Controls.Add(this.connectButton);
			this.groupBox1.Location = new System.Drawing.Point(24, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 162);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// UpdatePortsButton
			// 
			this.UpdatePortsButton.Location = new System.Drawing.Point(57, 95);
			this.UpdatePortsButton.Name = "UpdatePortsButton";
			this.UpdatePortsButton.Size = new System.Drawing.Size(121, 23);
			this.UpdatePortsButton.TabIndex = 4;
			this.UpdatePortsButton.Text = "Get COM-ports";
			this.UpdatePortsButton.UseVisualStyleBackColor = true;
			this.UpdatePortsButton.Click += new System.EventHandler(this.UpdatePortsButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(202, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Величина напряжения:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.AnswerTextBox);
			this.groupBox2.Controls.Add(this.CommandTextBox);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.SendCommandButton);
			this.groupBox2.Location = new System.Drawing.Point(297, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(237, 162);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ответ:";
			// 
			// AnswerTextBox
			// 
			this.AnswerTextBox.Enabled = false;
			this.AnswerTextBox.Location = new System.Drawing.Point(64, 116);
			this.AnswerTextBox.Name = "AnswerTextBox";
			this.AnswerTextBox.Size = new System.Drawing.Size(158, 22);
			this.AnswerTextBox.TabIndex = 5;
			// 
			// CommandTextBox
			// 
			this.CommandTextBox.Location = new System.Drawing.Point(41, 43);
			this.CommandTextBox.Name = "CommandTextBox";
			this.CommandTextBox.Size = new System.Drawing.Size(145, 22);
			this.CommandTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Командная строка";
			// 
			// SendCommandButton
			// 
			this.SendCommandButton.Location = new System.Drawing.Point(66, 71);
			this.SendCommandButton.Name = "SendCommandButton";
			this.SendCommandButton.Size = new System.Drawing.Size(91, 24);
			this.SendCommandButton.TabIndex = 1;
			this.SendCommandButton.Text = "Отправить";
			this.SendCommandButton.UseVisualStyleBackColor = true;
			this.SendCommandButton.Click += new System.EventHandler(this.SendCommandButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 273);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelTemp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comPortscomboBox;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.Label labelTemp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button UpdatePortsButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox AnswerTextBox;
		private System.Windows.Forms.TextBox CommandTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button SendCommandButton;
	}
}

