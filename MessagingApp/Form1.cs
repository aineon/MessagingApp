using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WMPLib;

namespace MessagingApp
{
    public partial class messagingApp : Form
    {
        public string CurrentTab { get; set; }
        public string RootDir { get; set; }
        public messagingApp()
        {
            InitializeComponent();
        }

        // Loads the application. poplulates inbox, gets root directory and disables sent/received radio buttons
        private void messagingApp_Load(object sender, EventArgs e)
        {
            LoadInbox();
            GetRootDirectory();
            DisableSentReceivedRbBtns();
        }

        // Loads all received messages into inbox
        private void LoadInbox()
        {
            // Status of Received Msg in table is R which means it belongs to the inbox
            CurrentTab = "R";
            string sql = "";

            if (rbSMS.Checked)
            {
                // hide media components on SMS load
                HideAllMediaComponents();

                sql = ($"Select * From Messages Where Status = '{CurrentTab}' and MMS = 0"); 

                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);

                // Clear out list box to avoid duplicate messages
                clbMsgIn.Items.Clear();
                clbMsgIn.DisplayMember = "Text";
                clbMsgIn.ValueMember = "Value";

                if (smsInfo.Count > 0)
                {
                    foreach (var sms in smsInfo)
                    {
                        clbMsgIn.Items.Add(new ListBoxItem { Text = sms.Recipient + ": " + sms.Text, Value = sms.ID.ToString() });
                    }
                }
            }
            else
            {
                sql = ($"Select * From Messages Where Status = '{CurrentTab}' and MMS = 1");

                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);

                clbMsgIn.Items.Clear();
                clbMsgIn.DisplayMember = "Text";
                clbMsgIn.ValueMember = "Value";

                if (mmsInfo.Count > 0)
                {
                    foreach (var mms in mmsInfo)
                    {
                        clbMsgIn.Items.Add(new ListBoxItem { Text = mms.Recipient + ": " + mms.Text, Value = mms.ID.ToString() });
                    }
                }
            }
        }

        // Loads Sent messages into SentMsg List Box
        private void LoadSentMsgs()
        {
            // Status of Received Msg in table is 'S' which means it belongs to the sent messages
            CurrentTab = "S";
            string sql = "";

            if (rbSMS.Checked)
            {
                sql = ($"Select * From Messages Where Status = '{CurrentTab}' and MMS = 0");

                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);

                clbSentMsg.Items.Clear();
                clbSentMsg.DisplayMember = "Text";
                clbSentMsg.ValueMember = "Value";

                if (smsInfo.Count > 0)
                {
                    foreach (var sms in smsInfo)
                    {
                        clbSentMsg.Items.Add(new ListBoxItem { Text = sms.Recipient + ": " + sms.Text, Value = sms.ID.ToString() });
                    }
                }
            }
            else
            {
                sql = ($"Select * From Messages Where Status = '{CurrentTab}' and MMS = 1");

                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);

                clbSentMsg.Items.Clear();
                clbSentMsg.DisplayMember = "Text";
                clbSentMsg.ValueMember = "Value";

                if (mmsInfo.Count > 0)
                {
                    foreach (var mms in mmsInfo)
                    {
                        clbSentMsg.Items.Add(new ListBoxItem { Text = mms.Recipient + ": " + mms.Text, Value = mms.ID.ToString() });
                    }
                }
            }
        }
        // Load inbox or sent msg box depending on tab selected
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBoxes();
        }

        // Show or hide components depending on which radio button is checked SMS or MMS. Load message into listboxes
        private void MessageRadioButtons_CheckedChange(object sender, EventArgs e)
        {
            ClearMsgFields();

            if (rbSMS.Checked)
            {
                HideAllMediaComponents();
            }
            else
            {
                ShowIntMediaComponents();
            }

            LoadListBoxes();
        }

        // Creates new SMS/MMS object. Retrieves data of the selected message
        private void LoadSelectedMessage()
        {
            string id = "";
            string recipient = "";
            string text = "";
            int mediaType = 0;
            string fName = "";
            
            if(CurrentTab == "R")
            {
                rbReceived.Checked = true;
                rbSent.Checked = false;
                lblNumber.Text = "Sender:";    // Change Recipient label to read Sender if msg is from Inbox
            }
            else
            {
                rbSent.Checked = true;
                rbReceived.Checked = false;
                lblNumber.Text = "Recipient:";
            }

            id = GetSelectedID();

            // Get data of selected message
            string sql = ($"Select * from Messages Where ID = '{id}'");

            if (rbSMS.Checked)
            {
                // returns a list of messages
                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);
                // create new SMS object
                SMS s = new SMS();

                if (smsInfo.Count > 0)
                {
                    var sms = smsInfo[0];
                    s.ID = sms.ID;
                    s.Sender = lblSender.Text;
                    s.Recipient = sms.Recipient;
                    s.Text = sms.Text;
                    s.IsGroupMessage = sms.IsGroupMessage;
                    s.Status = sms.Status;
                    s.MMS = sms.MMS;
                }

                recipient = s.Recipient;
                text = s.Text;

               if(s.IsGroupMessage)
               {
                    chbGroupMsg1.Checked= true;
               }
               else
               {
                    chbGroupMsg1.Checked= false;
               }
            }
            else
            {
                // returns a list of messages
                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);
                // create new MMS object
                MMS m = new MMS();

                if (mmsInfo.Count > 0)
                {
                    var mms = mmsInfo[0];
                    m.ID = mms.ID;
                    m.Sender = lblSender.Text;
                    m.Recipient = mms.Recipient;
                    m.Text = mms.Text;
                    m.IsGroupMessage = mms.IsGroupMessage;
                    m.Status = mms.Status;
                    m.MMS = mms.MMS;
                    m.Picture = mms.Picture;
                    m.Video = mms.Video;
                    m.Audio = mms.Audio;
                    m.FileName = mms.FileName;
                }

                recipient = m.Recipient;
                text = m.Text;

                if (m.IsGroupMessage)
                {
                    chbGroupMsg1.Checked = true;
                }
                else
                {
                    chbGroupMsg1.Checked = false;
                }

                if (m.Picture)
                {
                    mediaType = 1;
                }
                else if (m.Audio)
                {
                    mediaType = 2;
                }
                else if (m.Video)
                {
                    mediaType = 3;
                }
                else
                {
                    mediaType = 0;
                }

                fName = m.FileName;
            }

            txtbRecipient.Text = recipient;
            txtbMsg.Text = text;

            if (mediaType == 1)
            {
                rbPic.Checked = true;
                txtbFile.Text = fName;
                LoadPicure();
            }
            else if (mediaType == 2)
            {
                rbAudio.Checked = true;
                txtbFile.Text = fName;
            }
            else if (mediaType == 3)
            {
                rbVid.Checked = true;
                txtbFile.Text = fName;
            }
            else
            {
                rbPic.Checked = true;
                txtbFile.Text = "";
            }

            if (id.Length > 0)
            {
                DisableMessageComponents();
                DisableMediaComponents();
            }
            else
            {
                EnableMessageComponents();

                if (rbMMS.Checked)
                {
                    EnableMediaComponents();
                    ShowPicComponents();
                }
            }
        }
     
        // Load List boxes depending on which tab is selected - inbox/sent
        private void LoadListBoxes()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                LoadInbox();
            }
            else
            {
                LoadSentMsgs();
            }
        }

        // Makes the picture box visible and loads the selected image
        private void LoadPicure()
        {
            if (!pictureBox.Visible)
            {
                pictureBox.Visible = true;
            }

            string filePath = RootDir + "Images\\" + txtbFile.Text;

            // Create a new bitmap Object from the picture file at the location provided and assign it to the pictureBox.Image property
            pictureBox.Image = new Bitmap(filePath);
        }

        // loop through the messages and gets and returns the ID of the selected message
        private string GetSelectedID()
        {
            string id = "";

            if (CurrentTab == "R")
            {
                foreach (var itemChecked in clbMsgIn.CheckedItems)
                {
                    var msg = (ListBoxItem)itemChecked;
                    id = msg.Value;
                }
            }
            else
            {
                foreach (var itemChecked in clbSentMsg.CheckedItems)
                {
                    var msg = (ListBoxItem)itemChecked;
                    id = msg.Value;
                }
            }
            return id;
        }

        // Load message data of selected message
        private void MessageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedMessage();
        }

        // Controls which message in the listbox is checked
        private void MessageListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // create object of items
            CheckedListBox items = (CheckedListBox)sender;

            // if one or more items are checked 
            if (items.CheckedItems.Count >= 1)
            {
                // if one item is checked and you try to check another msg, the new msg you try to check will not check
                // if you want to check a new msg you need to uncheck the previously checked msg first
                e.NewValue = CheckState.Unchecked;
            }
        }

        // loop through message list and uncheck any checked messages
        private void UncheckListBoxItems()
        {
            if (CurrentTab == "R")
            {
                foreach (int itemCheckedIndex in clbMsgIn.CheckedIndices)
                {
                    clbMsgIn.SetItemChecked(itemCheckedIndex, false);
                }
            }
            else if (CurrentTab == "S")
            {
                foreach (int itemCheckedIndex in clbSentMsg.CheckedIndices)
                {
                    clbSentMsg.SetItemChecked(itemCheckedIndex, false);
                }
            }
        }

        // Clears data from all message fields
        private void ClearMsgFields()
        {
            txtbRecipient.Text = "";
            txtbMsg.Text = "";
            txtbFile.Text = "";
            chbGroupMsg1.Checked = false;
            rbReceived.Checked = false;
            rbSent.Checked = false;
        }

        // Gets count of list items that are checked
        private int GetCkdListBoxItemsCount()
        {
            int count = 0;
            if (CurrentTab == "R")
            {
                count = clbMsgIn.CheckedItems.Count;
            }
            else
            {
                count = clbSentMsg.CheckedItems.Count;
            }
            return count;
        }

        // Gets the root directory file path
        private void GetRootDirectory()
        {
            // To get the location of the assembly(project) folder
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Once we have the path value we get the directory using:
            var d = System.IO.Path.GetDirectoryName(path);
            var dir = d.Replace("bin\\Debug", "");

            RootDir = dir;
        }

        // Show media components based on which radio button is checked - picture or audio/video
        private void MediaRadioBtns_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPic.Checked)
            {
                ShowPicComponents();
            }
            else
            {
                ShowAudVidComponents();
            }
        }

        // Hide/Show Components

        // Clears out picturebox and hides media components
        private void HideMediaComponents()
        {
            pictureBox.Image = null;
            pictureBox.Visible = false;
            mediaPlayer.Visible = false;
            lblFile.Visible = false;
            btnFile.Visible = false;
            txtbFile.Text = "";
            txtbFile.Visible = false;
            btnPlay.Visible = false;
            btnStop.Visible = false;
            btnShow.Visible = false;
        }

        // Hides all media components
        private void HideAllMediaComponents()
        {
            HideMediaComponents();
            rbPic.Visible = false;
            rbAudio.Visible = false;
            rbVid.Visible = false;
        }

        // Makes media radio buttons and image components visible to the user
        private void ShowIntMediaComponents()
        {
            ShowPicComponents();
            rbPic.Visible = true;
            rbAudio.Visible = true;
            rbVid.Visible = true;
        }

        // Makes file browse, file textbox and label visible to the user
        private void ShowCommonMediaComponents()
        {
            lblFile.Visible = true;
            btnFile.Visible = true;
            txtbFile.Visible = true;
        }

        // Makes picture componets visible to the user
        private void ShowPicComponents()
        {
            HideMediaComponents();
            ShowCommonMediaComponents();
            pictureBox.Visible = true;
            btnShow.Visible = true;
            rbPic.Checked = true;
        }

        // Makes media controls visible to the user
        private void ShowAudVidComponents()
        {
            HideMediaComponents();
            ShowCommonMediaComponents();
            btnPlay.Visible = true;
            btnStop.Visible = true;
            mediaPlayer.Visible = true;
        }

        // Enable/Disable Components

        // Disable Send, cancel buttons, group message checkbox & sent/received radio buttons
        private void DisableMessageComponents()
        {
            btnCancel.Enabled = false;
            btnSend.Enabled = false;
            chbGroupMsg1.Enabled = false;
            DisableSentReceivedRbBtns();
        }

        // Enables Send, Cancel buttons and group message checkbox
        private void EnableMessageComponents()
        {
            btnCancel.Enabled = true;
            btnSend.Enabled = true;
            chbGroupMsg1.Enabled = true;
        }

        // Disables Sent/Receive radio buttons
        private void DisableSentReceivedRbBtns()
        {
            rbSent.Enabled = false;
            rbReceived.Enabled = false;
        }

        // Disables components in the media group box
        private void DisableMediaComponents()
        {
            rbPic.Enabled = false;
            rbAudio.Enabled = false;
            rbVid.Enabled = false;
            btnFile.Enabled = false;
            txtbFile.Enabled = false;
        }

        // Enables components in the media group box
        private void EnableMediaComponents()
        {
            rbPic.Enabled = true;
            rbAudio.Enabled = true;
            rbVid.Enabled = true;
            btnFile.Enabled = true;
            txtbFile.Enabled = true;
        }

        // Button Click Events

        // Clears all data from message fields, enables send & cancel buttons
        private void btnCompose_Click(object sender, EventArgs e)
        {
            UncheckListBoxItems();
            ClearMsgFields();
            EnableMessageComponents();

            if (rbMMS.Checked)
            {
                ShowIntMediaComponents();
                EnableMediaComponents();
            }
        }

        // Clears any data entered by the user into the message, recipient fields
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearMsgFields();
        }

        // Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Creates a Dialogue result object - to take user action
            DialogResult exitDialog = new DialogResult();  
            exitDialog = MessageBox.Show("Are you sure you want to exit?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // if user clicks yes on message box application will close
            if (exitDialog == DialogResult.Yes)
            {
                // Exits the Application when clicked
                Close();
            }
        }

        // Allows user to browse for an image, video or audio file
        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                string filePath = RootDir;

                if (rbPic.Checked)
                {
                    filePath += "Images\\";
                    ofd.Title = "Open Image";
                    ofd.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG;*.GIF;";
                }
                else if (rbAudio.Checked)
                {
                    filePath += "Audio\\";
                    ofd.Title = "Open Audio";
                    ofd.Filter = "Audio Files|*.wav;*.aac;*.wma;*.mp2;*.mp3;*.mpa;*.m3u;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi";
                }
                else if (rbVid.Checked)
                {
                    filePath += "Video\\";
                    ofd.Title = "Open Video";
                    ofd.Filter = "Video Files|*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mpe;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.mkv";
                }

                ofd.InitialDirectory = filePath;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var theFile = ofd.FileName.Replace(filePath, "");
                    txtbFile.Text = theFile;
                }
            }
        }

        // plays the selected/ loaded audio or video
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (rbAudio.Checked && txtbFile.TextLength > 0)
            {
                mediaPlayer.URL = RootDir + "Audio\\" + txtbFile.Text;
                btnPlay.Enabled = false;
            }
            else if (rbVid.Checked && txtbFile.TextLength > 0)
            {
                mediaPlayer.URL = RootDir + "Video\\" + txtbFile.Text;
                btnPlay.Enabled = false;
            }
        }

        // Stops audio or video from playing
        private void btnStop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
            btnPlay.Enabled = true;
        }

        // Loads the selected image
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtbFile.TextLength > 0)
            {
                LoadPicure();
            }
        }

        // Delete all data of the selected message from the DB
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result = 0;
            string sql = "";

            if (GetCkdListBoxItemsCount() > 0)
            {
                string id = GetSelectedID();
                sql = ($"Delete From Messages Where ID = '{id}';");
                
                result = Data.ExecuteSqlNonQuery(sql, CommandType.Text);

                if (result > 0)
                {
                    MessageBox.Show($"{result} message(s) deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearMsgFields();
                    LoadListBoxes();

                    if (rbMMS.Checked)
                    {
                        ShowPicComponents();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to Delete Message! \n Please try again!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Message Selected for deletion!", "Select A Message!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Sends all message data to the db
        private void btnSend_Click(object sender, EventArgs e)
        {
            int result = 0;
            string sql = "";
            string recipient = "";
            string msg = "";
            string file = "";
            int groupMsg = 0;

            if (chbGroupMsg1.Checked)
            {
                groupMsg = 1;
            }

            if (rbSMS.Checked)
            {
                if (txtbRecipient.TextLength > 0 && txtbMsg.TextLength > 0)
                {
                    recipient = txtbRecipient.Text;
                    msg = txtbMsg.Text;

                    sql = "Insert Into Messages(Status, Recipient, Text, IsGroupMessage  , MMS, Picture, Audio, Video, FileName)" +
                      "Values('S', '" + recipient + "', '" + msg + "', " + groupMsg + ", 0, 0, 0, 0, '')";
                }
                else
                {
                    MessageBox.Show("You have not Entered a Recipient/Message!", "Insufficent Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (txtbRecipient.TextLength > 0 && txtbMsg.TextLength > 0 && txtbFile.TextLength > 0)
                {
                    recipient = txtbRecipient.Text;
                    msg = txtbMsg.Text;
                    file = txtbFile.Text;

                    int pic = 0;
                    int audio = 0;
                    int video = 0;

                    if (rbPic.Checked)
                    {
                        pic = 1;
                    }
                    else if (rbAudio.Checked)
                    {
                        audio = 1;
                    }
                    else if (rbVid.Checked)
                    {
                        video = 1;
                    }

                    sql = "Insert Into Messages(Status, Recipient, Text, IsGroupMessage  , MMS, Picture, Audio, Video, FileName)" +
                     "Values('S', '" + recipient + "', '" + msg + "', " + groupMsg + ", 1, " + pic + ", " + audio + ", " + video + ", '" + file + "')";
                }
                else
                {
                    MessageBox.Show("You have not Entered a Recipient/Message/File!", "Insufficent Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (sql.Length > 0)
            {
                result = Data.ExecuteSqlNonQuery(sql, CommandType.Text);

                if (result > 0)
                {
                    MessageBox.Show($"{result} Message(s) Sent Successfully!", "Message Sent!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearMsgFields();

                    if (rbMMS.Checked)
                    {
                        ShowPicComponents();
                    }
                    LoadListBoxes();
                }
                else
                {
                    MessageBox.Show("Message Sending Failed!\nPlease try again!", "Send Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Message Not Sent!\nPlease try again!", "Send Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sent/Received Message data cleared from fields, send/cancel buttons still disabled
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMsgFields();
            UncheckListBoxItems();
            pictureBox.Image = null;
        }

        // Manage any media player errors
        private void MediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file,
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case MediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        // Onscreen help - gives users a description of what the component does when clicked on
        private void messagingApp_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Control requestingControl = (Control)sender;
            lblHelp.Text = (string)requestingControl.Tag;
            hlpevent.Handled = true;
        }
    }
}
