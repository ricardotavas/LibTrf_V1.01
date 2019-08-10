namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkMsgAuto = new System.Windows.Forms.CheckBox();
            this.label_speedMsg = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_decMsgAuto = new System.Windows.Forms.Button();
            this.button_IncMsgAuto = new System.Windows.Forms.Button();
            this.button_ClearText = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.comboFon = new System.Windows.Forms.ComboBox();
            this.comboPos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_SendSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioUART = new System.Windows.Forms.RadioButton();
            this.radioTCP = new System.Windows.Forms.RadioButton();
            this.radioUDP = new System.Windows.Forms.RadioButton();
            this.button_clear = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_statusCom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 203);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.button_ClearText);
            this.tabPage2.Controls.Add(this.textMessage);
            this.tabPage2.Controls.Add(this.comboFon);
            this.tabPage2.Controls.Add(this.comboPos);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mensagens";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkMsgAuto);
            this.groupBox4.Controls.Add(this.label_speedMsg);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.button_decMsgAuto);
            this.groupBox4.Controls.Add(this.button_IncMsgAuto);
            this.groupBox4.Location = new System.Drawing.Point(414, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 104);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Automático";
            // 
            // checkMsgAuto
            // 
            this.checkMsgAuto.AutoSize = true;
            this.checkMsgAuto.Location = new System.Drawing.Point(9, 19);
            this.checkMsgAuto.Name = "checkMsgAuto";
            this.checkMsgAuto.Size = new System.Drawing.Size(56, 17);
            this.checkMsgAuto.TabIndex = 49;
            this.checkMsgAuto.Text = "Enviar";
            this.checkMsgAuto.UseVisualStyleBackColor = true;
            // 
            // label_speedMsg
            // 
            this.label_speedMsg.AutoSize = true;
            this.label_speedMsg.Location = new System.Drawing.Point(53, 54);
            this.label_speedMsg.Name = "label_speedMsg";
            this.label_speedMsg.Size = new System.Drawing.Size(13, 13);
            this.label_speedMsg.TabIndex = 46;
            this.label_speedMsg.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Speed:";
            // 
            // button_decMsgAuto
            // 
            this.button_decMsgAuto.Location = new System.Drawing.Point(25, 75);
            this.button_decMsgAuto.Name = "button_decMsgAuto";
            this.button_decMsgAuto.Size = new System.Drawing.Size(16, 23);
            this.button_decMsgAuto.TabIndex = 48;
            this.button_decMsgAuto.Text = "-";
            this.button_decMsgAuto.UseVisualStyleBackColor = true;
            this.button_decMsgAuto.Click += new System.EventHandler(this.button_decMsgAuto_Click);
            // 
            // button_IncMsgAuto
            // 
            this.button_IncMsgAuto.Location = new System.Drawing.Point(9, 75);
            this.button_IncMsgAuto.Name = "button_IncMsgAuto";
            this.button_IncMsgAuto.Size = new System.Drawing.Size(16, 23);
            this.button_IncMsgAuto.TabIndex = 47;
            this.button_IncMsgAuto.Text = "+";
            this.button_IncMsgAuto.UseVisualStyleBackColor = true;
            this.button_IncMsgAuto.Click += new System.EventHandler(this.button_IncMsgAuto_Click);
            // 
            // button_ClearText
            // 
            this.button_ClearText.Location = new System.Drawing.Point(235, 70);
            this.button_ClearText.Name = "button_ClearText";
            this.button_ClearText.Size = new System.Drawing.Size(85, 23);
            this.button_ClearText.TabIndex = 21;
            this.button_ClearText.Text = "Limpar";
            this.button_ClearText.UseVisualStyleBackColor = true;
            this.button_ClearText.Click += new System.EventHandler(this.button_ClearText_Click);
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.Location = new System.Drawing.Point(7, 7);
            this.textMessage.Multiline = false;
            this.textMessage.Name = "textMessage";
            this.textMessage.ShortcutsEnabled = false;
            this.textMessage.Size = new System.Drawing.Size(614, 54);
            this.textMessage.TabIndex = 17;
            this.textMessage.Text = "";
            this.textMessage.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // comboFon
            // 
            this.comboFon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFon.FormattingEnabled = true;
            this.comboFon.Items.AddRange(new object[] {
            "218-Tabela 3x7",
            "219-Tabela 5x7",
            "220-Tabela 7x7",
            "221-Tabela 9x8",
            "222-Tabela 10x8",
            "223-Tabela 12x8",
            "224-Tabela 14x11"});
            this.comboFon.Location = new System.Drawing.Point(72, 98);
            this.comboFon.Name = "comboFon";
            this.comboFon.Size = new System.Drawing.Size(121, 21);
            this.comboFon.TabIndex = 19;
            this.comboFon.SelectedIndexChanged += new System.EventHandler(this.comboFon_SelectedIndexChanged);
            // 
            // comboPos
            // 
            this.comboPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPos.FormattingEnabled = true;
            this.comboPos.Items.AddRange(new object[] {
            "210=Tela Inteira",
            "211-Posição 1",
            "212-Posição 2"});
            this.comboPos.Location = new System.Drawing.Point(72, 72);
            this.comboPos.Name = "comboPos";
            this.comboPos.Size = new System.Drawing.Size(121, 21);
            this.comboPos.TabIndex = 18;
            this.comboPos.SelectedIndexChanged += new System.EventHandler(this.comboPos_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Fonte:";
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Posição:";
            // 
            // button_SendSet
            // 
            this.button_SendSet.Location = new System.Drawing.Point(233, 475);
            this.button_SendSet.Name = "button_SendSet";
            this.button_SendSet.Size = new System.Drawing.Size(85, 23);
            this.button_SendSet.TabIndex = 28;
            this.button_SendSet.Text = "Send Set";
            this.button_SendSet.UseVisualStyleBackColor = true;
            this.button_SendSet.Click += new System.EventHandler(this.button_SendSet_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioUART);
            this.groupBox2.Controls.Add(this.radioTCP);
            this.groupBox2.Controls.Add(this.radioUDP);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 71);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interface";
            // 
            // radioUART
            // 
            this.radioUART.AutoSize = true;
            this.radioUART.Location = new System.Drawing.Point(116, 29);
            this.radioUART.Name = "radioUART";
            this.radioUART.Size = new System.Drawing.Size(63, 17);
            this.radioUART.TabIndex = 28;
            this.radioUART.TabStop = true;
            this.radioUART.Text = "SERIAL";
            this.radioUART.UseVisualStyleBackColor = true;
            this.radioUART.CheckedChanged += new System.EventHandler(this.radioUART_CheckedChanged);
            // 
            // radioTCP
            // 
            this.radioTCP.AutoSize = true;
            this.radioTCP.Location = new System.Drawing.Point(64, 29);
            this.radioTCP.Name = "radioTCP";
            this.radioTCP.Size = new System.Drawing.Size(46, 17);
            this.radioTCP.TabIndex = 27;
            this.radioTCP.TabStop = true;
            this.radioTCP.Text = "TCP";
            this.radioTCP.UseVisualStyleBackColor = true;
            this.radioTCP.CheckedChanged += new System.EventHandler(this.radioTCP_CheckedChanged);
            // 
            // radioUDP
            // 
            this.radioUDP.AutoSize = true;
            this.radioUDP.Location = new System.Drawing.Point(10, 29);
            this.radioUDP.Name = "radioUDP";
            this.radioUDP.Size = new System.Drawing.Size(48, 17);
            this.radioUDP.TabIndex = 26;
            this.radioUDP.TabStop = true;
            this.radioUDP.Text = "UDP";
            this.radioUDP.UseVisualStyleBackColor = true;
            this.radioUDP.CheckedChanged += new System.EventHandler(this.radioUDP_CheckedChanged);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(324, 475);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 23);
            this.button_clear.TabIndex = 29;
            this.button_clear.Text = "Limpar log";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textLog
            // 
            this.textLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLog.Location = new System.Drawing.Point(5, 293);
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(632, 176);
            this.textLog.TabIndex = 26;
            this.textLog.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_statusCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBaudRate);
            this.groupBox1.Controls.Add(this.comboCom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Location = new System.Drawing.Point(200, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 71);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // label_statusCom
            // 
            this.label_statusCom.AllowDrop = true;
            this.label_statusCom.AutoSize = true;
            this.label_statusCom.Location = new System.Drawing.Point(361, 20);
            this.label_statusCom.Name = "label_statusCom";
            this.label_statusCom.Size = new System.Drawing.Size(0, 13);
            this.label_statusCom.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "BAUDRATE:";
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.comboBaudRate.Location = new System.Drawing.Point(234, 44);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBaudRate.TabIndex = 28;
            this.comboBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBaudRate_SelectedIndexChanged);
            this.comboBaudRate.Click += new System.EventHandler(this.comboBaudRate_SelectedIndexChanged);
            // 
            // comboCom
            // 
            this.comboCom.FormattingEnabled = true;
            this.comboCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboCom.Location = new System.Drawing.Point(234, 17);
            this.comboCom.Name = "comboCom";
            this.comboCom.Size = new System.Drawing.Size(121, 21);
            this.comboCom.TabIndex = 27;
            this.comboCom.SelectedIndexChanged += new System.EventHandler(this.comboCom_SelectedIndexChanged);
            this.comboCom.Click += new System.EventHandler(this.comboCom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "COM:";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "IP:";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(35, 28);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_IP.TabIndex = 24;
            this.textBox_IP.Text = "192.168.0.114";
            this.textBox_IP.TextChanged += new System.EventHandler(this.textBox_IP_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_SendSet);
            this.Name = "Form1";
            this.Text = "Terminal para teste do protocolo de tarifário - V1.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button_SendSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboFon;
        private System.Windows.Forms.ComboBox comboPos;
        private System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.Button button_ClearText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_speedMsg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_decMsgAuto;
        private System.Windows.Forms.Button button_IncMsgAuto;
        private System.Windows.Forms.CheckBox checkMsgAuto;
        private System.Windows.Forms.RadioButton radioUART;
        private System.Windows.Forms.RadioButton radioTCP;
        private System.Windows.Forms.RadioButton radioUDP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.Label label_statusCom;
    }
}

