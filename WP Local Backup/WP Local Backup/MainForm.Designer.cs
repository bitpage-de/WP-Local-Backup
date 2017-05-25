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
            this.textBoxRemoteAdress = new System.Windows.Forms.TextBox();
            this.labelRemoteAdress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelRemoteAdress);
            this.groupBox1.Controls.Add(this.textBoxRemoteAdress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Configuration";
            // 
            // textBoxRemoteAdress
            // 
            this.textBoxRemoteAdress.Location = new System.Drawing.Point(185, 50);
            this.textBoxRemoteAdress.Name = "textBoxRemoteAdress";
            this.textBoxRemoteAdress.Size = new System.Drawing.Size(171, 20);
            this.textBoxRemoteAdress.TabIndex = 0;
            // 
            // labelRemoteAdress
            // 
            this.labelRemoteAdress.AutoSize = true;
            this.labelRemoteAdress.Location = new System.Drawing.Point(36, 53);
            this.labelRemoteAdress.Name = "labelRemoteAdress";
            this.labelRemoteAdress.Size = new System.Drawing.Size(143, 13);
            this.labelRemoteAdress.TabIndex = 1;
            this.labelRemoteAdress.Text = "Remote Adress (IP or FQDN)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 389);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "WP Local Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRemoteAdress;
        private System.Windows.Forms.Label labelRemoteAdress;
        private System.Windows.Forms.Label label1;
    }
}

