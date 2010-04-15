namespace SqlServerExport
{
    partial class MainForm
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ServerHost = new System.Windows.Forms.TextBox();
            this.ServerUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerPassword = new System.Windows.Forms.TextBox();
            this.ServerDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(728, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ServerHost
            // 
            this.ServerHost.Location = new System.Drawing.Point(47, 6);
            this.ServerHost.Name = "ServerHost";
            this.ServerHost.Size = new System.Drawing.Size(100, 20);
            this.ServerHost.TabIndex = 1;
            // 
            // ServerUsername
            // 
            this.ServerUsername.Location = new System.Drawing.Point(222, 6);
            this.ServerUsername.Name = "ServerUsername";
            this.ServerUsername.Size = new System.Drawing.Size(100, 20);
            this.ServerUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // ServerPassword
            // 
            this.ServerPassword.Location = new System.Drawing.Point(400, 6);
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.Size = new System.Drawing.Size(100, 20);
            this.ServerPassword.TabIndex = 6;
            // 
            // ServerDatabase
            // 
            this.ServerDatabase.Location = new System.Drawing.Point(582, 6);
            this.ServerDatabase.Name = "ServerDatabase";
            this.ServerDatabase.Size = new System.Drawing.Size(100, 20);
            this.ServerDatabase.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database";
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(15, 49);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(883, 375);
            this.Output.TabIndex = 9;
            this.Output.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 436);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServerDatabase);
            this.Controls.Add(this.ServerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerUsername);
            this.Controls.Add(this.ServerHost);
            this.Controls.Add(this.ConnectButton);
            this.Name = "MainForm";
            this.Text = "SqlServerExport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ServerHost;
        private System.Windows.Forms.TextBox ServerUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerPassword;
        private System.Windows.Forms.TextBox ServerDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Output;
    }
}

