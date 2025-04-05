namespace MessagingApp
{
    partial class messagingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messagingApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbMMS = new System.Windows.Forms.RadioButton();
            this.rbSMS = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.clbMsgIn = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clbSentMsg = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mediaBox = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtbFile = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.rbVid = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.rbPic = new System.Windows.Forms.RadioButton();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbRecipient = new System.Windows.Forms.TextBox();
            this.txtbMsg = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbSent = new System.Windows.Forms.RadioButton();
            this.rbReceived = new System.Windows.Forms.RadioButton();
            this.chbGroupMsg1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Status = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.mediaBox.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(151)))), ((int)(((byte)(187)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblSender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1407, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 51);
            this.btnExit.TabIndex = 9;
            this.btnExit.Tag = "Use this button to Exit the application.";
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.ForeColor = System.Drawing.Color.White;
            this.lblSender.Location = new System.Drawing.Point(184, 18);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(217, 39);
            this.lblSender.TabIndex = 2;
            this.lblSender.Text = "0872734258";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sender:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(258, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.rbMMS);
            this.panel3.Controls.Add(this.rbSMS);
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 836);
            this.panel3.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(251, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 50);
            this.btnNew.TabIndex = 3;
            this.btnNew.Tag = "Use this button to unselect any selected messages and clear all textboxes so a ne" +
    "w message can be composed";
            this.btnNew.Text = "Compose";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnCompose_Click);
            this.btnNew.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(407, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Tag = "Use this button delete the selected message.";
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // rbMMS
            // 
            this.rbMMS.AutoSize = true;
            this.rbMMS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbMMS.Location = new System.Drawing.Point(122, 26);
            this.rbMMS.Name = "rbMMS";
            this.rbMMS.Size = new System.Drawing.Size(89, 33);
            this.rbMMS.TabIndex = 2;
            this.rbMMS.Tag = "Select message type MMS to send messages containing text and Media or to load MMS" +
    " messages";
            this.rbMMS.Text = "MMS";
            this.rbMMS.UseVisualStyleBackColor = true;
            this.rbMMS.CheckedChanged += new System.EventHandler(this.MessageRadioButtons_CheckedChange);
            this.rbMMS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // rbSMS
            // 
            this.rbSMS.AutoSize = true;
            this.rbSMS.Checked = true;
            this.rbSMS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbSMS.Location = new System.Drawing.Point(32, 26);
            this.rbSMS.Name = "rbSMS";
            this.rbSMS.Size = new System.Drawing.Size(83, 33);
            this.rbSMS.TabIndex = 1;
            this.rbSMS.TabStop = true;
            this.rbSMS.Tag = "Select message type SMS to send text messages with no media can be attached., or " +
    "to load SMS messages";
            this.rbSMS.Text = "SMS";
            this.rbSMS.UseVisualStyleBackColor = true;
            this.rbSMS.CheckedChanged += new System.EventHandler(this.MessageRadioButtons_CheckedChange);
            this.rbSMS.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 728);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "Select the \'Inbox\' tab to see your received messages. Select the \'Sent\' tab to se" +
    "e your received messages.";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.clbMsgIn);
            this.tabpage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpage1.Location = new System.Drawing.Point(4, 38);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(524, 686);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Inbox";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // clbMsgIn
            // 
            this.clbMsgIn.CheckOnClick = true;
            this.clbMsgIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbMsgIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(75)))), ((int)(((byte)(93)))));
            this.clbMsgIn.FormattingEnabled = true;
            this.clbMsgIn.HorizontalScrollbar = true;
            this.clbMsgIn.Location = new System.Drawing.Point(3, 3);
            this.clbMsgIn.Name = "clbMsgIn";
            this.clbMsgIn.Size = new System.Drawing.Size(518, 680);
            this.clbMsgIn.TabIndex = 0;
            this.clbMsgIn.Tag = "Displays all received messages.";
            this.clbMsgIn.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MessageListBox_ItemCheck);
            this.clbMsgIn.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            this.clbMsgIn.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clbSentMsg);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 686);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sent";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clbSentMsg
            // 
            this.clbSentMsg.CheckOnClick = true;
            this.clbSentMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSentMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(17)))), ((int)(((byte)(48)))));
            this.clbSentMsg.FormattingEnabled = true;
            this.clbSentMsg.HorizontalExtent = 800;
            this.clbSentMsg.HorizontalScrollbar = true;
            this.clbSentMsg.Location = new System.Drawing.Point(3, 3);
            this.clbSentMsg.Name = "clbSentMsg";
            this.clbSentMsg.Size = new System.Drawing.Size(518, 680);
            this.clbSentMsg.TabIndex = 0;
            this.clbSentMsg.Tag = "Displays all Sent messages.";
            this.clbSentMsg.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MessageListBox_ItemCheck);
            this.clbSentMsg.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            this.clbSentMsg.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.mediaBox);
            this.panel4.Location = new System.Drawing.Point(582, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1130, 438);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mediaPlayer);
            this.panel5.Controls.Add(this.pictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(352, -35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(778, 473);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(732, 470);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "Displays the selected picture. Displays received pictures.";
            this.pictureBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // mediaBox
            // 
            this.mediaBox.Controls.Add(this.btnShow);
            this.mediaBox.Controls.Add(this.btnStop);
            this.mediaBox.Controls.Add(this.btnPlay);
            this.mediaBox.Controls.Add(this.txtbFile);
            this.mediaBox.Controls.Add(this.btnFile);
            this.mediaBox.Controls.Add(this.lblFile);
            this.mediaBox.Controls.Add(this.rbVid);
            this.mediaBox.Controls.Add(this.rbAudio);
            this.mediaBox.Controls.Add(this.rbPic);
            this.mediaBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.mediaBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mediaBox.Location = new System.Drawing.Point(0, 0);
            this.mediaBox.Name = "mediaBox";
            this.mediaBox.Size = new System.Drawing.Size(352, 438);
            this.mediaBox.TabIndex = 0;
            this.mediaBox.TabStop = false;
            this.mediaBox.Text = "Media";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(220, 282);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 40);
            this.btnShow.TabIndex = 13;
            this.btnShow.Tag = "Use this button to show a valid picture file once it is selected.";
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(114, 282);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 40);
            this.btnStop.TabIndex = 12;
            this.btnStop.Tag = "Use this button to stop the media file when it is playing or finished playing.";
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnPlay.FlatAppearance.BorderSize = 2;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(6, 282);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 40);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Tag = "Use this button to play a valid media file once it is selected.";
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // txtbFile
            // 
            this.txtbFile.Location = new System.Drawing.Point(6, 224);
            this.txtbFile.Name = "txtbFile";
            this.txtbFile.Size = new System.Drawing.Size(334, 36);
            this.txtbFile.TabIndex = 11;
            this.txtbFile.Tag = "Enter the file name in this text box.";
            this.txtbFile.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // btnFile
            // 
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(146, 183);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(68, 35);
            this.btnFile.TabIndex = 10;
            this.btnFile.Tag = "Use this button to browse for a media file to add to an MMS message.";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            this.btnFile.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblFile.Location = new System.Drawing.Point(17, 183);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(123, 29);
            this.lblFile.TabIndex = 9;
            this.lblFile.Text = "Select file:";
            // 
            // rbVid
            // 
            this.rbVid.AutoSize = true;
            this.rbVid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbVid.Location = new System.Drawing.Point(22, 127);
            this.rbVid.Name = "rbVid";
            this.rbVid.Size = new System.Drawing.Size(96, 33);
            this.rbVid.TabIndex = 6;
            this.rbVid.Tag = "Select to add media type Video.";
            this.rbVid.Text = "Video";
            this.rbVid.UseVisualStyleBackColor = true;
            this.rbVid.CheckedChanged += new System.EventHandler(this.MediaRadioBtns_CheckedChanged);
            this.rbVid.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbAudio.Location = new System.Drawing.Point(22, 88);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(96, 33);
            this.rbAudio.TabIndex = 5;
            this.rbAudio.Tag = "Select to add media type Audio.";
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            this.rbAudio.CheckedChanged += new System.EventHandler(this.MediaRadioBtns_CheckedChanged);
            this.rbAudio.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // rbPic
            // 
            this.rbPic.AutoSize = true;
            this.rbPic.Checked = true;
            this.rbPic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.rbPic.FlatAppearance.BorderSize = 2;
            this.rbPic.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.rbPic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbPic.Location = new System.Drawing.Point(22, 49);
            this.rbPic.Name = "rbPic";
            this.rbPic.Size = new System.Drawing.Size(110, 33);
            this.rbPic.TabIndex = 5;
            this.rbPic.TabStop = true;
            this.rbPic.Tag = "Select to add media type Picture.";
            this.rbPic.Text = "Picture";
            this.rbPic.UseVisualStyleBackColor = true;
            this.rbPic.CheckedChanged += new System.EventHandler(this.MediaRadioBtns_CheckedChanged);
            this.rbPic.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNumber.Location = new System.Drawing.Point(609, 98);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(117, 29);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Tag = "Displays number of sender if message is in inbox or recipient if it is a sent mes" +
    "sage";
            this.lblNumber.Text = "Recipient:";
            this.lblNumber.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(612, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message:";
            // 
            // txtbRecipient
            // 
            this.txtbRecipient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRecipient.Location = new System.Drawing.Point(751, 89);
            this.txtbRecipient.MaxLength = 10;
            this.txtbRecipient.Name = "txtbRecipient";
            this.txtbRecipient.Size = new System.Drawing.Size(406, 36);
            this.txtbRecipient.TabIndex = 5;
            this.txtbRecipient.Tag = "Enter the recipients contact number in this text box.";
            this.txtbRecipient.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // txtbMsg
            // 
            this.txtbMsg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMsg.Location = new System.Drawing.Point(751, 153);
            this.txtbMsg.MaxLength = 255;
            this.txtbMsg.Multiline = true;
            this.txtbMsg.Name = "txtbMsg";
            this.txtbMsg.Size = new System.Drawing.Size(588, 225);
            this.txtbMsg.TabIndex = 6;
            this.txtbMsg.Tag = "Enter the message text in this text box.";
            this.txtbMsg.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1408, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 51);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Tag = "Use this button to clear all textboxes.";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(1408, 213);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(158, 51);
            this.btnSend.TabIndex = 8;
            this.btnSend.Tag = "Use this button to send the composed message.";
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // rbSent
            // 
            this.rbSent.AutoSize = true;
            this.rbSent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbSent.Location = new System.Drawing.Point(604, 245);
            this.rbSent.Name = "rbSent";
            this.rbSent.Size = new System.Drawing.Size(85, 33);
            this.rbSent.TabIndex = 5;
            this.rbSent.Tag = "Denotes that the message being viewed was sent.";
            this.rbSent.Text = "Sent";
            this.rbSent.UseVisualStyleBackColor = true;
            this.rbSent.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // rbReceived
            // 
            this.rbReceived.AutoSize = true;
            this.rbReceived.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbReceived.Location = new System.Drawing.Point(602, 284);
            this.rbReceived.Name = "rbReceived";
            this.rbReceived.Size = new System.Drawing.Size(133, 33);
            this.rbReceived.TabIndex = 10;
            this.rbReceived.Tag = "Denotes the message being viewed was received.";
            this.rbReceived.Text = "Received";
            this.rbReceived.UseVisualStyleBackColor = true;
            this.rbReceived.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // chbGroupMsg1
            // 
            this.chbGroupMsg1.AutoSize = true;
            this.chbGroupMsg1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGroupMsg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chbGroupMsg1.Location = new System.Drawing.Point(1231, 91);
            this.chbGroupMsg1.Name = "chbGroupMsg1";
            this.chbGroupMsg1.Size = new System.Drawing.Size(204, 33);
            this.chbGroupMsg1.TabIndex = 1;
            this.chbGroupMsg1.Tag = "Check this box if your message is a group message.";
            this.chbGroupMsg1.Text = "Group Message";
            this.chbGroupMsg1.UseVisualStyleBackColor = true;
            this.chbGroupMsg1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(1343, 269);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 33);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Received";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Status.Location = new System.Drawing.Point(599, 213);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(98, 29);
            this.Status.TabIndex = 11;
            this.Status.Text = "Status:";
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.White;
            this.lblHelp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.Blue;
            this.lblHelp.Location = new System.Drawing.Point(-3, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(1130, 52);
            this.lblHelp.TabIndex = 14;
            this.lblHelp.Text = resources.GetString("lblHelp.Text");
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblHelp);
            this.panel6.Location = new System.Drawing.Point(582, 841);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1127, 52);
            this.panel6.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(79)))), ((int)(((byte)(137)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1408, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 51);
            this.btnClear.TabIndex = 13;
            this.btnClear.Tag = "Use this button to clear all message fields";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(778, 473);
            this.mediaPlayer.TabIndex = 1;
            // 
            // messagingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1712, 907);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.chbGroupMsg1);
            this.Controls.Add(this.rbReceived);
            this.Controls.Add(this.rbSent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbMsg);
            this.Controls.Add(this.txtbRecipient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "messagingApp";
            this.Text = "Messaging App";
            this.Load += new System.EventHandler(this.messagingApp_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.messagingApp_HelpRequested);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.mediaBox.ResumeLayout(false);
            this.mediaBox.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RadioButton rbMMS;
        private System.Windows.Forms.RadioButton rbSMS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.CheckedListBox clbMsgIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox clbSentMsg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox mediaBox;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtbFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.RadioButton rbVid;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.RadioButton rbPic;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbRecipient;
        private System.Windows.Forms.TextBox txtbMsg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton rbSent;
        private System.Windows.Forms.RadioButton rbReceived;
        private System.Windows.Forms.RadioButton chbGroupMsg;
        private System.Windows.Forms.CheckBox chbGroupMsg1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnClear;
    }
}

