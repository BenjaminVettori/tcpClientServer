namespace tcpIPClient
{
    partial class FormMain
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
            this.groupBoxClientServer = new System.Windows.Forms.GroupBox();
            this.buttonClientConnect = new System.Windows.Forms.Button();
            this.textBoxServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClientProtocol = new System.Windows.Forms.GroupBox();
            this.comboBoxClientProtocol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientDelimiter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxClientKeyboard = new System.Windows.Forms.GroupBox();
            this.checkBoxEveryKeystroke = new System.Windows.Forms.CheckBox();
            this.buttonClientSendClear = new System.Windows.Forms.Button();
            this.buttonClientSend = new System.Windows.Forms.Button();
            this.textBoxClientSend = new System.Windows.Forms.TextBox();
            this.groupBoxClientReceive = new System.Windows.Forms.GroupBox();
            this.buttonClientRecieveClear = new System.Windows.Forms.Button();
            this.textBoxClientReceive = new System.Windows.Forms.TextBox();
            this.groupBoxClientLog = new System.Windows.Forms.GroupBox();
            this.buttonClientLogClear = new System.Windows.Forms.Button();
            this.textBoxClientLog = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.groupBoxServerRecieve = new System.Windows.Forms.GroupBox();
            this.buttonServerRecieveClear = new System.Windows.Forms.Button();
            this.textBoxServerRecieve = new System.Windows.Forms.TextBox();
            this.groupBoxServerKeyboard = new System.Windows.Forms.GroupBox();
            this.buttonServerSendClear = new System.Windows.Forms.Button();
            this.groupBoxServerProtocol = new System.Windows.Forms.GroupBox();
            this.comboBoxServerProtocol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxServerDelimiter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonServerSend = new System.Windows.Forms.Button();
            this.textBoxServerSend = new System.Windows.Forms.TextBox();
            this.groupBoxServerLog = new System.Windows.Forms.GroupBox();
            this.buttonServerLogClear = new System.Windows.Forms.Button();
            this.textBoxServerLog = new System.Windows.Forms.TextBox();
            this.groupBoxServerServer = new System.Windows.Forms.GroupBox();
            this.textBoxClientsConnected = new System.Windows.Forms.TextBox();
            this.buttonListen = new System.Windows.Forms.Button();
            this.textBoxListenPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeViewClients = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxClientServer.SuspendLayout();
            this.groupBoxClientProtocol.SuspendLayout();
            this.groupBoxClientKeyboard.SuspendLayout();
            this.groupBoxClientReceive.SuspendLayout();
            this.groupBoxClientLog.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            this.tabPageServer.SuspendLayout();
            this.groupBoxServerRecieve.SuspendLayout();
            this.groupBoxServerKeyboard.SuspendLayout();
            this.groupBoxServerProtocol.SuspendLayout();
            this.groupBoxServerLog.SuspendLayout();
            this.groupBoxServerServer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientServer
            // 
            this.groupBoxClientServer.Controls.Add(this.buttonClientConnect);
            this.groupBoxClientServer.Controls.Add(this.textBoxServerPort);
            this.groupBoxClientServer.Controls.Add(this.label2);
            this.groupBoxClientServer.Controls.Add(this.textBoxServerName);
            this.groupBoxClientServer.Controls.Add(this.label1);
            this.groupBoxClientServer.Location = new System.Drawing.Point(8, 6);
            this.groupBoxClientServer.Name = "groupBoxClientServer";
            this.groupBoxClientServer.Size = new System.Drawing.Size(322, 94);
            this.groupBoxClientServer.TabIndex = 0;
            this.groupBoxClientServer.TabStop = false;
            this.groupBoxClientServer.Text = "Server";
            // 
            // buttonClientConnect
            // 
            this.buttonClientConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientConnect.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonClientConnect.Location = new System.Drawing.Point(9, 65);
            this.buttonClientConnect.Name = "buttonClientConnect";
            this.buttonClientConnect.Size = new System.Drawing.Size(307, 23);
            this.buttonClientConnect.TabIndex = 4;
            this.buttonClientConnect.Text = "Connect";
            this.buttonClientConnect.UseVisualStyleBackColor = true;
            this.buttonClientConnect.Click += new System.EventHandler(this.buttonClientconnect_Click);
            // 
            // textBoxServerPort
            // 
            this.textBoxServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxServerPort.Location = new System.Drawing.Point(108, 39);
            this.textBoxServerPort.Name = "textBoxServerPort";
            this.textBoxServerPort.Size = new System.Drawing.Size(208, 20);
            this.textBoxServerPort.TabIndex = 3;
            this.textBoxServerPort.Text = "4000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serverport:";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxServerName.Location = new System.Drawing.Point(108, 13);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(208, 20);
            this.textBoxServerName.TabIndex = 1;
            this.textBoxServerName.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server-Name / -IP:";
            // 
            // groupBoxClientProtocol
            // 
            this.groupBoxClientProtocol.Controls.Add(this.comboBoxClientProtocol);
            this.groupBoxClientProtocol.Controls.Add(this.label3);
            this.groupBoxClientProtocol.Controls.Add(this.textBoxClientDelimiter);
            this.groupBoxClientProtocol.Controls.Add(this.label4);
            this.groupBoxClientProtocol.Enabled = false;
            this.groupBoxClientProtocol.Location = new System.Drawing.Point(336, 6);
            this.groupBoxClientProtocol.Name = "groupBoxClientProtocol";
            this.groupBoxClientProtocol.Size = new System.Drawing.Size(331, 94);
            this.groupBoxClientProtocol.TabIndex = 4;
            this.groupBoxClientProtocol.TabStop = false;
            this.groupBoxClientProtocol.Text = "Protocol";
            // 
            // comboBoxClientProtocol
            // 
            this.comboBoxClientProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxClientProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientProtocol.FormattingEnabled = true;
            this.comboBoxClientProtocol.Items.AddRange(new object[] {
            "on",
            "off"});
            this.comboBoxClientProtocol.Location = new System.Drawing.Point(60, 54);
            this.comboBoxClientProtocol.Name = "comboBoxClientProtocol";
            this.comboBoxClientProtocol.Size = new System.Drawing.Size(265, 21);
            this.comboBoxClientProtocol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protocol:";
            // 
            // textBoxClientDelimiter
            // 
            this.textBoxClientDelimiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxClientDelimiter.Location = new System.Drawing.Point(60, 28);
            this.textBoxClientDelimiter.Name = "textBoxClientDelimiter";
            this.textBoxClientDelimiter.Size = new System.Drawing.Size(265, 20);
            this.textBoxClientDelimiter.TabIndex = 1;
            this.textBoxClientDelimiter.Text = "+";
            this.textBoxClientDelimiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Delimiter:";
            // 
            // groupBoxClientKeyboard
            // 
            this.groupBoxClientKeyboard.Controls.Add(this.checkBoxEveryKeystroke);
            this.groupBoxClientKeyboard.Controls.Add(this.buttonClientSendClear);
            this.groupBoxClientKeyboard.Controls.Add(this.buttonClientSend);
            this.groupBoxClientKeyboard.Controls.Add(this.textBoxClientSend);
            this.groupBoxClientKeyboard.Enabled = false;
            this.groupBoxClientKeyboard.Location = new System.Drawing.Point(8, 106);
            this.groupBoxClientKeyboard.Name = "groupBoxClientKeyboard";
            this.groupBoxClientKeyboard.Size = new System.Drawing.Size(322, 133);
            this.groupBoxClientKeyboard.TabIndex = 4;
            this.groupBoxClientKeyboard.TabStop = false;
            this.groupBoxClientKeyboard.Text = "Keyboard";
            // 
            // checkBoxEveryKeystroke
            // 
            this.checkBoxEveryKeystroke.AutoSize = true;
            this.checkBoxEveryKeystroke.Location = new System.Drawing.Point(30, 108);
            this.checkBoxEveryKeystroke.Name = "checkBoxEveryKeystroke";
            this.checkBoxEveryKeystroke.Size = new System.Drawing.Size(103, 17);
            this.checkBoxEveryKeystroke.TabIndex = 4;
            this.checkBoxEveryKeystroke.Text = "Every Keystroke";
            this.checkBoxEveryKeystroke.UseVisualStyleBackColor = true;
            // 
            // buttonClientSendClear
            // 
            this.buttonClientSendClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClientSendClear.Location = new System.Drawing.Point(160, 104);
            this.buttonClientSendClear.Name = "buttonClientSendClear";
            this.buttonClientSendClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClientSendClear.TabIndex = 3;
            this.buttonClientSendClear.Text = "Clear";
            this.buttonClientSendClear.UseVisualStyleBackColor = true;
            this.buttonClientSendClear.Click += new System.EventHandler(this.buttonClientSendClear_Click);
            // 
            // buttonClientSend
            // 
            this.buttonClientSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientSend.ForeColor = System.Drawing.Color.Navy;
            this.buttonClientSend.Location = new System.Drawing.Point(241, 104);
            this.buttonClientSend.Name = "buttonClientSend";
            this.buttonClientSend.Size = new System.Drawing.Size(75, 23);
            this.buttonClientSend.TabIndex = 2;
            this.buttonClientSend.Text = "Send";
            this.buttonClientSend.UseVisualStyleBackColor = true;
            this.buttonClientSend.Click += new System.EventHandler(this.buttonClientSend_Click);
            // 
            // textBoxClientSend
            // 
            this.textBoxClientSend.Location = new System.Drawing.Point(6, 19);
            this.textBoxClientSend.Multiline = true;
            this.textBoxClientSend.Name = "textBoxClientSend";
            this.textBoxClientSend.Size = new System.Drawing.Size(310, 80);
            this.textBoxClientSend.TabIndex = 1;
            this.textBoxClientSend.TextChanged += new System.EventHandler(this.textBoxClientSend_TextChanged);
            // 
            // groupBoxClientReceive
            // 
            this.groupBoxClientReceive.Controls.Add(this.buttonClientRecieveClear);
            this.groupBoxClientReceive.Controls.Add(this.textBoxClientReceive);
            this.groupBoxClientReceive.Enabled = false;
            this.groupBoxClientReceive.Location = new System.Drawing.Point(8, 245);
            this.groupBoxClientReceive.Name = "groupBoxClientReceive";
            this.groupBoxClientReceive.Size = new System.Drawing.Size(322, 194);
            this.groupBoxClientReceive.TabIndex = 5;
            this.groupBoxClientReceive.TabStop = false;
            this.groupBoxClientReceive.Text = "Recieve";
            // 
            // buttonClientRecieveClear
            // 
            this.buttonClientRecieveClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClientRecieveClear.Location = new System.Drawing.Point(275, 19);
            this.buttonClientRecieveClear.Name = "buttonClientRecieveClear";
            this.buttonClientRecieveClear.Size = new System.Drawing.Size(41, 169);
            this.buttonClientRecieveClear.TabIndex = 3;
            this.buttonClientRecieveClear.Text = "Clear";
            this.buttonClientRecieveClear.UseVisualStyleBackColor = true;
            this.buttonClientRecieveClear.Click += new System.EventHandler(this.buttonClientRecieveClear_Click);
            // 
            // textBoxClientReceive
            // 
            this.textBoxClientReceive.Location = new System.Drawing.Point(6, 19);
            this.textBoxClientReceive.Multiline = true;
            this.textBoxClientReceive.Name = "textBoxClientReceive";
            this.textBoxClientReceive.ReadOnly = true;
            this.textBoxClientReceive.Size = new System.Drawing.Size(263, 169);
            this.textBoxClientReceive.TabIndex = 1;
            // 
            // groupBoxClientLog
            // 
            this.groupBoxClientLog.Controls.Add(this.buttonClientLogClear);
            this.groupBoxClientLog.Controls.Add(this.textBoxClientLog);
            this.groupBoxClientLog.Location = new System.Drawing.Point(336, 106);
            this.groupBoxClientLog.Name = "groupBoxClientLog";
            this.groupBoxClientLog.Size = new System.Drawing.Size(331, 333);
            this.groupBoxClientLog.TabIndex = 6;
            this.groupBoxClientLog.TabStop = false;
            this.groupBoxClientLog.Text = "Log";
            // 
            // buttonClientLogClear
            // 
            this.buttonClientLogClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonClientLogClear.Location = new System.Drawing.Point(6, 303);
            this.buttonClientLogClear.Name = "buttonClientLogClear";
            this.buttonClientLogClear.Size = new System.Drawing.Size(319, 24);
            this.buttonClientLogClear.TabIndex = 3;
            this.buttonClientLogClear.Text = "Clear";
            this.buttonClientLogClear.UseVisualStyleBackColor = true;
            this.buttonClientLogClear.Click += new System.EventHandler(this.buttonClientLogClear_Click);
            // 
            // textBoxClientLog
            // 
            this.textBoxClientLog.Location = new System.Drawing.Point(6, 19);
            this.textBoxClientLog.Multiline = true;
            this.textBoxClientLog.Name = "textBoxClientLog";
            this.textBoxClientLog.ReadOnly = true;
            this.textBoxClientLog.Size = new System.Drawing.Size(319, 278);
            this.textBoxClientLog.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageClient);
            this.tabControl.Controls.Add(this.tabPageServer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(683, 468);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.groupBoxClientServer);
            this.tabPageClient.Controls.Add(this.groupBoxClientLog);
            this.tabPageClient.Controls.Add(this.groupBoxClientKeyboard);
            this.tabPageClient.Controls.Add(this.groupBoxClientProtocol);
            this.tabPageClient.Controls.Add(this.groupBoxClientReceive);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(675, 442);
            this.tabPageClient.TabIndex = 0;
            this.tabPageClient.Text = "Client";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // tabPageServer
            // 
            this.tabPageServer.Controls.Add(this.groupBoxServerRecieve);
            this.tabPageServer.Controls.Add(this.groupBoxServerKeyboard);
            this.tabPageServer.Controls.Add(this.groupBoxServerLog);
            this.tabPageServer.Controls.Add(this.groupBoxServerServer);
            this.tabPageServer.Controls.Add(this.treeViewClients);
            this.tabPageServer.Location = new System.Drawing.Point(4, 22);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(675, 442);
            this.tabPageServer.TabIndex = 1;
            this.tabPageServer.Text = "Server";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // groupBoxServerRecieve
            // 
            this.groupBoxServerRecieve.Controls.Add(this.buttonServerRecieveClear);
            this.groupBoxServerRecieve.Controls.Add(this.textBoxServerRecieve);
            this.groupBoxServerRecieve.Enabled = false;
            this.groupBoxServerRecieve.Location = new System.Drawing.Point(235, 266);
            this.groupBoxServerRecieve.Name = "groupBoxServerRecieve";
            this.groupBoxServerRecieve.Size = new System.Drawing.Size(209, 173);
            this.groupBoxServerRecieve.TabIndex = 9;
            this.groupBoxServerRecieve.TabStop = false;
            this.groupBoxServerRecieve.Text = "Recieve";
            // 
            // buttonServerRecieveClear
            // 
            this.buttonServerRecieveClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonServerRecieveClear.Location = new System.Drawing.Point(6, 143);
            this.buttonServerRecieveClear.Name = "buttonServerRecieveClear";
            this.buttonServerRecieveClear.Size = new System.Drawing.Size(197, 24);
            this.buttonServerRecieveClear.TabIndex = 4;
            this.buttonServerRecieveClear.Text = "Clear";
            this.buttonServerRecieveClear.UseVisualStyleBackColor = true;
            this.buttonServerRecieveClear.Click += new System.EventHandler(this.buttonServerRecieveClear_Click);
            // 
            // textBoxServerRecieve
            // 
            this.textBoxServerRecieve.Location = new System.Drawing.Point(6, 19);
            this.textBoxServerRecieve.Multiline = true;
            this.textBoxServerRecieve.Name = "textBoxServerRecieve";
            this.textBoxServerRecieve.ReadOnly = true;
            this.textBoxServerRecieve.Size = new System.Drawing.Size(197, 118);
            this.textBoxServerRecieve.TabIndex = 1;
            // 
            // groupBoxServerKeyboard
            // 
            this.groupBoxServerKeyboard.Controls.Add(this.buttonServerSendClear);
            this.groupBoxServerKeyboard.Controls.Add(this.groupBoxServerProtocol);
            this.groupBoxServerKeyboard.Controls.Add(this.buttonServerSend);
            this.groupBoxServerKeyboard.Controls.Add(this.textBoxServerSend);
            this.groupBoxServerKeyboard.Enabled = false;
            this.groupBoxServerKeyboard.Location = new System.Drawing.Point(235, 80);
            this.groupBoxServerKeyboard.Name = "groupBoxServerKeyboard";
            this.groupBoxServerKeyboard.Size = new System.Drawing.Size(209, 180);
            this.groupBoxServerKeyboard.TabIndex = 8;
            this.groupBoxServerKeyboard.TabStop = false;
            this.groupBoxServerKeyboard.Text = "Keyboard";
            // 
            // buttonServerSendClear
            // 
            this.buttonServerSendClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonServerSendClear.Location = new System.Drawing.Point(6, 75);
            this.buttonServerSendClear.Name = "buttonServerSendClear";
            this.buttonServerSendClear.Size = new System.Drawing.Size(93, 23);
            this.buttonServerSendClear.TabIndex = 3;
            this.buttonServerSendClear.Text = "Clear";
            this.buttonServerSendClear.UseVisualStyleBackColor = true;
            this.buttonServerSendClear.Click += new System.EventHandler(this.buttonServerSendClear_Click);
            // 
            // groupBoxServerProtocol
            // 
            this.groupBoxServerProtocol.Controls.Add(this.comboBoxServerProtocol);
            this.groupBoxServerProtocol.Controls.Add(this.label6);
            this.groupBoxServerProtocol.Controls.Add(this.textBoxServerDelimiter);
            this.groupBoxServerProtocol.Controls.Add(this.label7);
            this.groupBoxServerProtocol.Location = new System.Drawing.Point(6, 104);
            this.groupBoxServerProtocol.Name = "groupBoxServerProtocol";
            this.groupBoxServerProtocol.Size = new System.Drawing.Size(197, 68);
            this.groupBoxServerProtocol.TabIndex = 5;
            this.groupBoxServerProtocol.TabStop = false;
            this.groupBoxServerProtocol.Text = "Protocol";
            // 
            // comboBoxServerProtocol
            // 
            this.comboBoxServerProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxServerProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServerProtocol.FormattingEnabled = true;
            this.comboBoxServerProtocol.Items.AddRange(new object[] {
            "on",
            "off"});
            this.comboBoxServerProtocol.Location = new System.Drawing.Point(62, 39);
            this.comboBoxServerProtocol.Name = "comboBoxServerProtocol";
            this.comboBoxServerProtocol.Size = new System.Drawing.Size(129, 21);
            this.comboBoxServerProtocol.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Protocol:";
            // 
            // textBoxServerDelimiter
            // 
            this.textBoxServerDelimiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxServerDelimiter.Location = new System.Drawing.Point(62, 13);
            this.textBoxServerDelimiter.Name = "textBoxServerDelimiter";
            this.textBoxServerDelimiter.Size = new System.Drawing.Size(129, 20);
            this.textBoxServerDelimiter.TabIndex = 1;
            this.textBoxServerDelimiter.Text = "+";
            this.textBoxServerDelimiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Delimiter:";
            // 
            // buttonServerSend
            // 
            this.buttonServerSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServerSend.ForeColor = System.Drawing.Color.Navy;
            this.buttonServerSend.Location = new System.Drawing.Point(105, 75);
            this.buttonServerSend.Name = "buttonServerSend";
            this.buttonServerSend.Size = new System.Drawing.Size(98, 23);
            this.buttonServerSend.TabIndex = 2;
            this.buttonServerSend.Text = "Send";
            this.buttonServerSend.UseVisualStyleBackColor = true;
            // 
            // textBoxServerSend
            // 
            this.textBoxServerSend.Location = new System.Drawing.Point(6, 19);
            this.textBoxServerSend.Multiline = true;
            this.textBoxServerSend.Name = "textBoxServerSend";
            this.textBoxServerSend.Size = new System.Drawing.Size(197, 50);
            this.textBoxServerSend.TabIndex = 1;
            // 
            // groupBoxServerLog
            // 
            this.groupBoxServerLog.Controls.Add(this.buttonServerLogClear);
            this.groupBoxServerLog.Controls.Add(this.textBoxServerLog);
            this.groupBoxServerLog.Location = new System.Drawing.Point(450, 6);
            this.groupBoxServerLog.Name = "groupBoxServerLog";
            this.groupBoxServerLog.Size = new System.Drawing.Size(217, 433);
            this.groupBoxServerLog.TabIndex = 7;
            this.groupBoxServerLog.TabStop = false;
            this.groupBoxServerLog.Text = "Log";
            // 
            // buttonServerLogClear
            // 
            this.buttonServerLogClear.ForeColor = System.Drawing.Color.Navy;
            this.buttonServerLogClear.Location = new System.Drawing.Point(6, 403);
            this.buttonServerLogClear.Name = "buttonServerLogClear";
            this.buttonServerLogClear.Size = new System.Drawing.Size(204, 24);
            this.buttonServerLogClear.TabIndex = 3;
            this.buttonServerLogClear.Text = "Clear";
            this.buttonServerLogClear.UseVisualStyleBackColor = true;
            this.buttonServerLogClear.Click += new System.EventHandler(this.buttonServerLogClear_Click);
            // 
            // textBoxServerLog
            // 
            this.textBoxServerLog.Location = new System.Drawing.Point(6, 19);
            this.textBoxServerLog.Multiline = true;
            this.textBoxServerLog.Name = "textBoxServerLog";
            this.textBoxServerLog.ReadOnly = true;
            this.textBoxServerLog.Size = new System.Drawing.Size(204, 378);
            this.textBoxServerLog.TabIndex = 1;
            // 
            // groupBoxServerServer
            // 
            this.groupBoxServerServer.Controls.Add(this.textBoxClientsConnected);
            this.groupBoxServerServer.Controls.Add(this.buttonListen);
            this.groupBoxServerServer.Controls.Add(this.textBoxListenPort);
            this.groupBoxServerServer.Controls.Add(this.label5);
            this.groupBoxServerServer.Location = new System.Drawing.Point(235, 6);
            this.groupBoxServerServer.Name = "groupBoxServerServer";
            this.groupBoxServerServer.Size = new System.Drawing.Size(209, 68);
            this.groupBoxServerServer.TabIndex = 1;
            this.groupBoxServerServer.TabStop = false;
            this.groupBoxServerServer.Text = "Server";
            // 
            // textBoxClientsConnected
            // 
            this.textBoxClientsConnected.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxClientsConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClientsConnected.Enabled = false;
            this.textBoxClientsConnected.Location = new System.Drawing.Point(9, 39);
            this.textBoxClientsConnected.Name = "textBoxClientsConnected";
            this.textBoxClientsConnected.ReadOnly = true;
            this.textBoxClientsConnected.Size = new System.Drawing.Size(194, 20);
            this.textBoxClientsConnected.TabIndex = 5;
            this.textBoxClientsConnected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonListen
            // 
            this.buttonListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListen.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonListen.Location = new System.Drawing.Point(122, 11);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(81, 23);
            this.buttonListen.TabIndex = 4;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // textBoxListenPort
            // 
            this.textBoxListenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxListenPort.Location = new System.Drawing.Point(41, 13);
            this.textBoxListenPort.Name = "textBoxListenPort";
            this.textBoxListenPort.Size = new System.Drawing.Size(75, 20);
            this.textBoxListenPort.TabIndex = 3;
            this.textBoxListenPort.Text = "4000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Port:";
            // 
            // treeViewClients
            // 
            this.treeViewClients.Enabled = false;
            this.treeViewClients.Location = new System.Drawing.Point(3, 6);
            this.treeViewClients.Name = "treeViewClients";
            this.treeViewClients.Size = new System.Drawing.Size(226, 433);
            this.treeViewClients.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(683, 492);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "MrChat";
            this.groupBoxClientServer.ResumeLayout(false);
            this.groupBoxClientServer.PerformLayout();
            this.groupBoxClientProtocol.ResumeLayout(false);
            this.groupBoxClientProtocol.PerformLayout();
            this.groupBoxClientKeyboard.ResumeLayout(false);
            this.groupBoxClientKeyboard.PerformLayout();
            this.groupBoxClientReceive.ResumeLayout(false);
            this.groupBoxClientReceive.PerformLayout();
            this.groupBoxClientLog.ResumeLayout(false);
            this.groupBoxClientLog.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageClient.ResumeLayout(false);
            this.tabPageServer.ResumeLayout(false);
            this.groupBoxServerRecieve.ResumeLayout(false);
            this.groupBoxServerRecieve.PerformLayout();
            this.groupBoxServerKeyboard.ResumeLayout(false);
            this.groupBoxServerKeyboard.PerformLayout();
            this.groupBoxServerProtocol.ResumeLayout(false);
            this.groupBoxServerProtocol.PerformLayout();
            this.groupBoxServerLog.ResumeLayout(false);
            this.groupBoxServerLog.PerformLayout();
            this.groupBoxServerServer.ResumeLayout(false);
            this.groupBoxServerServer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientServer;
        private System.Windows.Forms.TextBox textBoxServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxClientProtocol;
        private System.Windows.Forms.ComboBox comboBoxClientProtocol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientDelimiter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxClientKeyboard;
        private System.Windows.Forms.TextBox textBoxClientSend;
        private System.Windows.Forms.Button buttonClientSendClear;
        private System.Windows.Forms.Button buttonClientSend;
        private System.Windows.Forms.Button buttonClientConnect;
        private System.Windows.Forms.CheckBox checkBoxEveryKeystroke;
        private System.Windows.Forms.GroupBox groupBoxClientReceive;
        private System.Windows.Forms.Button buttonClientRecieveClear;
        private System.Windows.Forms.TextBox textBoxClientReceive;
        private System.Windows.Forms.GroupBox groupBoxClientLog;
        private System.Windows.Forms.Button buttonClientLogClear;
        private System.Windows.Forms.TextBox textBoxClientLog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.TabPage tabPageServer;
        private System.Windows.Forms.GroupBox groupBoxServerServer;
        private System.Windows.Forms.TextBox textBoxClientsConnected;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.TextBox textBoxListenPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeViewClients;
        private System.Windows.Forms.GroupBox groupBoxServerKeyboard;
        private System.Windows.Forms.Button buttonServerSendClear;
        private System.Windows.Forms.Button buttonServerSend;
        private System.Windows.Forms.TextBox textBoxServerSend;
        private System.Windows.Forms.GroupBox groupBoxServerLog;
        private System.Windows.Forms.Button buttonServerLogClear;
        private System.Windows.Forms.TextBox textBoxServerLog;
        private System.Windows.Forms.GroupBox groupBoxServerProtocol;
        private System.Windows.Forms.ComboBox comboBoxServerProtocol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxServerDelimiter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxServerRecieve;
        private System.Windows.Forms.Button buttonServerRecieveClear;
        private System.Windows.Forms.TextBox textBoxServerRecieve;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

