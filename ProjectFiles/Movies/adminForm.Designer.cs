namespace Movies
{
    partial class adminForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.genresButton = new System.Windows.Forms.Button();
            this.castButton = new System.Windows.Forms.Button();
            this.moviesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainLogoPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 561);
            this.mainPanel.TabIndex = 4;
            // 
            // mainLogoPictureBox
            // 
            this.mainLogoPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainLogoPictureBox.Image = global::Movies.Properties.Resources.mainLogoAdmin;
            this.mainLogoPictureBox.Location = new System.Drawing.Point(166, 60);
            this.mainLogoPictureBox.Name = "mainLogoPictureBox";
            this.mainLogoPictureBox.Size = new System.Drawing.Size(355, 400);
            this.mainLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainLogoPictureBox.TabIndex = 1;
            this.mainLogoPictureBox.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.leftPanel.Controls.Add(this.logoutButton);
            this.leftPanel.Controls.Add(this.settingsButton);
            this.leftPanel.Controls.Add(this.genresButton);
            this.leftPanel.Controls.Add(this.castButton);
            this.leftPanel.Controls.Add(this.moviesButton);
            this.leftPanel.Controls.Add(this.usersButton);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 561);
            this.leftPanel.TabIndex = 3;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.logoutButton.Location = new System.Drawing.Point(0, 460);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutButton.Size = new System.Drawing.Size(200, 60);
            this.logoutButton.TabIndex = 6;
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
            this.settingsButton.Location = new System.Drawing.Point(0, 400);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingsButton.Size = new System.Drawing.Size(200, 60);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // genresButton
            // 
            this.genresButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.genresButton.FlatAppearance.BorderSize = 0;
            this.genresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.genresButton.Location = new System.Drawing.Point(0, 340);
            this.genresButton.Name = "genresButton";
            this.genresButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.genresButton.Size = new System.Drawing.Size(200, 60);
            this.genresButton.TabIndex = 4;
            this.genresButton.Text = "Zarządzaj gatunkami";
            this.genresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genresButton.UseVisualStyleBackColor = true;
            this.genresButton.Click += new System.EventHandler(this.genresButton_Click);
            // 
            // castButton
            // 
            this.castButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.castButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.castButton.FlatAppearance.BorderSize = 0;
            this.castButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.castButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.castButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.castButton.Location = new System.Drawing.Point(0, 280);
            this.castButton.Name = "castButton";
            this.castButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.castButton.Size = new System.Drawing.Size(200, 60);
            this.castButton.TabIndex = 3;
            this.castButton.Text = "Zarządzaj obsadą";
            this.castButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.castButton.UseVisualStyleBackColor = true;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // moviesButton
            // 
            this.moviesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.moviesButton.FlatAppearance.BorderSize = 0;
            this.moviesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moviesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moviesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.moviesButton.Location = new System.Drawing.Point(0, 220);
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.moviesButton.Size = new System.Drawing.Size(200, 60);
            this.moviesButton.TabIndex = 2;
            this.moviesButton.Text = "Zarządzaj filmami";
            this.moviesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moviesButton.UseVisualStyleBackColor = true;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.usersButton.Location = new System.Drawing.Point(0, 160);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.usersButton.Size = new System.Drawing.Size(200, 60);
            this.usersButton.TabIndex = 1;
            this.usersButton.Text = "Zarządzaj użytkownikami";
            this.usersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
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
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::Movies.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza filmowa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminForm_FormClosing);
            this.Click += new System.EventHandler(this.logoPictureBox_Click);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogoPictureBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox mainLogoPictureBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button genresButton;
        private System.Windows.Forms.Button moviesButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.Button logoutButton;
    }
}