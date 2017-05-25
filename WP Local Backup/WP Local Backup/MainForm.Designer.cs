namespace WP_Local_Backup
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRemoteAdress = new System.Windows.Forms.Label();
            this.textBoxRemoteAdress = new System.Windows.Forms.TextBox();
            this.buttonCreateBackup = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.labelPathWordpressRoot = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonCreateBackup);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Configuration";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(18, 58);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelRemoteAdress
            // 
            this.labelRemoteAdress.AutoSize = true;
            this.labelRemoteAdress.Location = new System.Drawing.Point(18, 26);
            this.labelRemoteAdress.Name = "labelRemoteAdress";
            this.labelRemoteAdress.Size = new System.Drawing.Size(143, 13);
            this.labelRemoteAdress.TabIndex = 1;
            this.labelRemoteAdress.Text = "Remote Adress (IP or FQDN)";
            // 
            // textBoxRemoteAdress
            // 
            this.textBoxRemoteAdress.Location = new System.Drawing.Point(167, 23);
            this.textBoxRemoteAdress.Name = "textBoxRemoteAdress";
            this.textBoxRemoteAdress.Size = new System.Drawing.Size(171, 20);
            this.textBoxRemoteAdress.TabIndex = 0;
            // 
            // buttonCreateBackup
            // 
            this.buttonCreateBackup.Location = new System.Drawing.Point(39, 421);
            this.buttonCreateBackup.Name = "buttonCreateBackup";
            this.buttonCreateBackup.Size = new System.Drawing.Size(104, 23);
            this.buttonCreateBackup.TabIndex = 1;
            this.buttonCreateBackup.Text = "Create Backup";
            this.buttonCreateBackup.UseVisualStyleBackColor = true;
            this.buttonCreateBackup.Click += new System.EventHandler(this.buttonCreateBackup_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(167, 51);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(171, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(18, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(167, 84);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.PasswordChar = '*';
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBoxPassword.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.labelPathWordpressRoot);
            this.groupBox2.Controls.Add(this.buttonTestConnection);
            this.groupBox2.Controls.Add(this.labelRemoteAdress);
            this.groupBox2.Controls.Add(this.maskedTextBoxPassword);
            this.groupBox2.Controls.Add(this.textBoxRemoteAdress);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.labelUsername);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Location = new System.Drawing.Point(18, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wordpress Files";
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.Location = new System.Drawing.Point(234, 117);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(104, 23);
            this.buttonTestConnection.TabIndex = 6;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // labelPathWordpressRoot
            // 
            this.labelPathWordpressRoot.AutoSize = true;
            this.labelPathWordpressRoot.Location = new System.Drawing.Point(18, 154);
            this.labelPathWordpressRoot.Name = "labelPathWordpressRoot";
            this.labelPathWordpressRoot.Size = new System.Drawing.Size(95, 13);
            this.labelPathWordpressRoot.TabIndex = 7;
            this.labelPathWordpressRoot.Text = "Path to Wordpress";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 531);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "WP Local Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRemoteAdress;
        private System.Windows.Forms.Label labelRemoteAdress;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonCreateBackup;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Label labelPathWordpressRoot;
        private System.Windows.Forms.TextBox textBox1;
    }
}

