using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Local_Backup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateBackup_Click(object sender, EventArgs e)
        {
            var connectionInfo = new ConnectionInfo(this.textBoxRemoteAdress.Text,
                                                    this.textBoxUsername.Text,
                                                    new PasswordAuthenticationMethod(this.textBoxUsername.Text,
                                                                                     this.maskedTextBoxPassword.Text));
            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();
                    if(client.IsConnected)
                    {
                        // Get Directories
                        // Remember: Everything in UNIX-type OS is a file, even directories
                        List<SftpFile> files = client.ListDirectory("/").ToList<SftpFile>();
                        //client.DownloadFile();

                    }
                    else
                    {
                        // TODO: handle failure 
                        
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection could not be established.");
                    return;
                }
            }

         }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            var connectionInfo = new ConnectionInfo(this.textBoxRemoteAdress.Text,
                                                    this.textBoxUsername.Text,
                                                    new PasswordAuthenticationMethod(this.textBoxUsername.Text,
                                                                                     this.maskedTextBoxPassword.Text));
            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Connection could not be established.");
                    return;
                }

                if(client.IsConnected)
                {
                    MessageBox.Show("Connection successfully established.");
                }
                else
                {
                    MessageBox.Show("Connection could not be established.");
                }
            }
        }
    }
}
