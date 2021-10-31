namespace Movies
{
    partial class userForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.wantToSeeButton = new System.Windows.Forms.Button();
            this.ratingsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.leftPanel.Controls.Add(this.logoutButton);
            this.leftPanel.Controls.Add(this.settingsButton);
            this.leftPanel.Controls.Add(this.wantToSeeButton);
            this.leftPanel.Controls.Add(this.ratingsButton);
            this.leftPanel.Controls.Add(this.searchButton);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 561);
            this.leftPanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.logoutButton.Location = new System.Drawing.Point(0, 400);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutButton.Size = new System.Drawing.Size(200, 60);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.settingsButton.Location = new System.Drawing.Point(0, 340);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingsButton.Size = new System.Drawing.Size(200, 60);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // wantToSeeButton
            // 
            this.wantToSeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wantToSeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.wantToSeeButton.FlatAppearance.BorderSize = 0;
            this.wantToSeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wantToSeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wantToSeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.wantToSeeButton.Location = new System.Drawing.Point(0, 280);
            this.wantToSeeButton.Name = "wantToSeeButton";
            this.wantToSeeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.wantToSeeButton.Size = new System.Drawing.Size(200, 60);
            this.wantToSeeButton.TabIndex = 3;
            this.wantToSeeButton.Text = "Do obejrzenia";
            this.wantToSeeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wantToSeeButton.UseVisualStyleBackColor = true;
            this.wantToSeeButton.Click += new System.EventHandler(this.wantToSeeButton_Click);
            // 
            // ratingsButton
            // 
            this.ratingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ratingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ratingsButton.FlatAppearance.BorderSize = 0;
            this.ratingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ratingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.ratingsButton.Location = new System.Drawing.Point(0, 220);
            this.ratingsButton.Name = "ratingsButton";
            this.ratingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ratingsButton.Size = new System.Drawing.Size(200, 60);
            this.ratingsButton.TabIndex = 2;
            this.ratingsButton.Text = "Obejrzane";
            this.ratingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ratingsButton.UseVisualStyleBackColor = true;
            this.ratingsButton.Click += new System.EventHandler(this.ratingsButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.searchButton.Location = new System.Drawing.Point(0, 160);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.searchButton.Size = new System.Drawing.Size(200, 60);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Szukaj";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 160);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Image = global::Movies.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(50, 20);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainLogoPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 561);
            this.mainPanel.TabIndex = 2;
            // 
            // mainLogoPictureBox
            // 
            this.mainLogoPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainLogoPictureBox.Image = global::Movies.Properties.Resources.mainLogo;
            this.mainLogoPictureBox.Location = new System.Drawing.Point(166, 60);
            this.mainLogoPictureBox.Name = "mainLogoPictureBox";
            this.mainLogoPictureBox.Size = new System.Drawing.Size(355, 400);
            this.mainLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogoPictureBox.TabIndex = 1;
            this.mainLogoPictureBox.TabStop = false;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Movies.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza filmowa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userForm_FormClosing);
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button wantToSeeButton;
        private System.Windows.Forms.Button ratingsButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox mainLogoPictureBox;
        private System.Windows.Forms.Button logoutButton;
    }
}