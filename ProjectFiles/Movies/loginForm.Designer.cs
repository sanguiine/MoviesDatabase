namespace Movies
{
    partial class loginForm
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.White;
            this.emailTextBox.Location = new System.Drawing.Point(45, 209);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(216, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.White;
            this.emailPanel.Location = new System.Drawing.Point(45, 233);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(250, 1);
            this.emailPanel.TabIndex = 3;
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.Image = global::Movies.Properties.Resources.email2;
            this.emailPictureBox.Location = new System.Drawing.Point(267, 206);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Size = new System.Drawing.Size(28, 28);
            this.emailPictureBox.TabIndex = 2;
            this.emailPictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Movies.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(111, 30);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.Location = new System.Drawing.Point(45, 293);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(250, 1);
            this.passwordPanel.TabIndex = 6;
            // 
            // passwordPictureBox
            // 
            this.passwordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordPictureBox.Image = global::Movies.Properties.Resources.password2;
            this.passwordPictureBox.ImageLocation = "";
            this.passwordPictureBox.Location = new System.Drawing.Point(267, 263);
            this.passwordPictureBox.Name = "passwordPictureBox";
            this.passwordPictureBox.Size = new System.Drawing.Size(28, 28);
            this.passwordPictureBox.TabIndex = 5;
            this.passwordPictureBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(45, 269);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(216, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(111, 357);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(128, 40);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.emailLabel.Location = new System.Drawing.Point(42, 190);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 17);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.passwordLabel.Location = new System.Drawing.Point(42, 250);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(41, 17);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Hasło";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.errorLabel.Location = new System.Drawing.Point(121, 307);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 10;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.passwordPictureBox);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailPictureBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Movies.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza filmowa - logowanie";
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox emailPictureBox;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.PictureBox passwordPictureBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}