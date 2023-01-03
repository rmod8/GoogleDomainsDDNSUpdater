using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GoogleDomainsDDNSUpdater
{
    public partial class Form1 : Form
    {
        //Hide the credentials
        private static bool hideText = true;
        //Config file name
        private static string configFile = "config.ini";
        //IP type
        private static IPType IP = IPType.IPv4;
        enum IPType
        {
            IPv4,
            IPv6
        }
        Thread RefreshThread;


        public Form1()
        {
            InitializeComponent();
            comboIPChoice.SelectedIndex = 0;


            //If the save credential file exists...
            if (File.Exists(configFile))
            {
                string[] lines = File.ReadAllLines(configFile);
                //Check if file is valid
                if (lines.Length == 6 && lines[4].Length == 1)
                {
                    textUsername.Text = EncryptionTools.Decrypt(lines[0]);
                    textPassword.Text = EncryptionTools.Decrypt(lines[1]);
                    textDomain.Text = EncryptionTools.Decrypt(lines[2]);
                    if (lines[3] == "\u0001")
                        IP = IPType.IPv6;
                    else
                        IP = IPType.IPv4;
                    comboIPChoice.SelectedIndex = (int)IP;
                    nDelayInMinutes.Value = Convert.ToDecimal(lines[5]);
                    //Check if the program needs to start the RefreshThread when we start
                    if (lines[4][0] == (char)1)
                    {
                        checkStartOn.Checked = true;
                        buttonStart_Click(this, null);
                    }

                }
                else
                    saveConfig(true);
            }
        }

        //Method used for the RefreshThread. This method sends data to google domain's update server, then pauses for the specified time in the gui
        internal void RefreshDDNS()
        {
            while (true)
            {
                try
                {
                    using (var client = new WebClient { Credentials = new NetworkCredential(textUsername.Text, textPassword.Text) })
                    {

                        string response = client.DownloadString("https://domains.google.com/nic/update?hostname=" + textDomain.Text + "&myip=" +
                            GetIPProvider());
                        this.statusStrip.Items[0].Text = "Status: " + response + DateTime.Now.ToString(" - dd-MM-yyyy h:mm:ss tt");
                    }
                }
                catch (Exception)
                {
                    this.statusStrip.Items[0].Text = "Status: Connection Error" + DateTime.Now.ToString(" - dd-MM-yyyy h:mm:ss tt");
                }
                Thread.Sleep(Convert.ToInt32(nDelayInMinutes.Value * 60000));
            }
        }


        //Returns Device's IP based on the IP type thats in the variable IP
        internal string GetIPProvider()
        {
            Console.WriteLine(IP);
            if (IP == IPType.IPv4)
            {
                using (var client = new WebClient())
                {
                    return client.DownloadString(@"https://api.ipify.org");
                }
            }
            else
            {
                using (var client = new WebClient())
                {
                    return client.DownloadString(@"https://api64.ipify.org");
                }
            }
        }


        //Boilerplate function, helps to enable or disable only inputs we want to disable. We don't want to disable the 'stop' button for example.
        private void InputEnable(bool option)
        {
            textUsername.Enabled = option;
            textPassword.Enabled = option;
            comboIPChoice.Enabled = option;
            textDomain.Enabled = option;
            nDelayInMinutes.Enabled = option;
            checkStartOn.Enabled = option;
            buttonLock.Enabled = option;
        }

        //Start the refresh thread
        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textUsername.Text))
            {
                MessageBox.Show("Please enter a Username.", "Configuration Problem");
                textUsername.Focus();
                return;
            }
            if (hideText == false)
                buttonLock_Click(null, null);
            RefreshThread = new Thread(new ThreadStart(RefreshDDNS));
            RefreshThread.Start();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            InputEnable(false);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            RefreshThread.Abort();
            InputEnable(true);
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        //This is probably unsafe but this just kills the refresh thread and savs the configuration
        private void StopThread(object sender, EventArgs e)
        {
            if (RefreshThread != null)
                try
                {
                    RefreshThread.Abort();
                    saveConfig(false);
                }
                catch
                {

                }
            else
                saveConfig(true);
        }

        internal void saveConfig(bool EncryptAndGetDataFromTextboxes)
        {
            try
            {
                FileStream fs = File.Create(configFile);
                BinaryWriter bw = new BinaryWriter(fs);

                //This means the program was closed whislt idle
                //This means we need to encrypt the data before we save it
                string Username = EncryptionTools.Crypt(textUsername.Text);
                string Password = EncryptionTools.Crypt(textPassword.Text);
                string Domain = EncryptionTools.Crypt(textDomain.Text);

                string[] encryptedCredentials = { Username, Password, Domain };

                //Write credentials
                for (int i = 0; i < encryptedCredentials.Length; i++)
                {
                    for (int x = 0; x < encryptedCredentials[i].Length; x++)
                    {
                        bw.Write(encryptedCredentials[i][x]);
                    }
                    bw.Write('\n');
                }
                bw.Write((char)(int)IP);
                bw.Write('\n');
                bw.Write(checkStartOn.Checked);
                bw.Write('\n');
                bw.Write(Convert.ToInt32(nDelayInMinutes.Value).ToString().ToCharArray());

                bw.Dispose();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Config File Failed to Save\n" + ex);
            }

        }

        //Credit hyperlink
        private void hyperlFam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://www.famfamfam.com/lab/icons/silk/");
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            hideText = !hideText;
            if (hideText)
            {
                textUsername.PasswordChar = '*';
                textPassword.PasswordChar = '*';
                buttonLock.BackgroundImage.Dispose();
                buttonLock.BackgroundImage = Properties.Resources.lock_open;
            }
            else
            {
                textUsername.PasswordChar = (char)0;
                textPassword.PasswordChar = (char)0;
                buttonLock.BackgroundImage.Dispose();
                buttonLock.BackgroundImage = Properties.Resources._lock;
            }
        }

        private void comboIPChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            IP = (IPType)comboIPChoice.SelectedIndex;
        }
    }

    //This is not the best encryption layout as the data is still left unencrypted in program memory.
    //This data is also machine dependant, so the configuration file can't be transfered to another machine, this is both good and bad.
    internal static class EncryptionTools
    {
        public static string Crypt(this string text)
        {
            return Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser));
        }

        public static string Decrypt(this string text)
        {
            return Encoding.Unicode.GetString(ProtectedData.Unprotect((Convert.FromBase64String(text)), null, DataProtectionScope.CurrentUser));
        }
    }
}
