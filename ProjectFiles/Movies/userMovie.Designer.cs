using System.Drawing;

namespace Movies
{
    partial class userMovie
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
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionTitleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.directorTitleLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.writerTitleLabel = new System.Windows.Forms.Label();
            this.writerLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreTitleLabel = new System.Windows.Forms.Label();
            this.wantToSeeCheckBox = new System.Windows.Forms.CheckBox();
            this.watchedCheckBox = new System.Windows.Forms.CheckBox();
            this.rateTitleLabel = new System.Windows.Forms.Label();
            this.rateTrackBar = new System.Windows.Forms.TrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.noAverageLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coverPictureBox.Location = new System.Drawing.Point(22, 89);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(220, 308);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.titleLabel.Location = new System.Drawing.Point(19, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(91, 50);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // descriptionTitleLabel
            // 
            this.descriptionTitleLabel.AutoSize = true;
            this.descriptionTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.descriptionTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.descriptionTitleLabel.Location = new System.Drawing.Point(23, 424);
            this.descriptionTitleLabel.Name = "descriptionTitleLabel";
            this.descriptionTitleLabel.Size = new System.Drawing.Size(55, 30);
            this.descriptionTitleLabel.TabIndex = 3;
            this.descriptionTitleLabel.Text = "Opis";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.descriptionLabel.Location = new System.Drawing.Point(24, 454);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(635, 98);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Tmp";
            // 
            // directorTitleLabel
            // 
            this.directorTitleLabel.AutoSize = true;
            this.directorTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.directorTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.directorTitleLabel.Location = new System.Drawing.Point(260, 99);
            this.directorTitleLabel.Name = "directorTitleLabel";
            this.directorTitleLabel.Size = new System.Drawing.Size(90, 25);
            this.directorTitleLabel.TabIndex = 5;
            this.directorTitleLabel.Text = "Reżyseria";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.directorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.directorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.directorLabel.Location = new System.Drawing.Point(260, 124);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(0, 21);
            this.directorLabel.TabIndex = 6;
            // 
            // writerTitleLabel
            // 
            this.writerTitleLabel.AutoSize = true;
            this.writerTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.writerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.writerTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.writerTitleLabel.Location = new System.Drawing.Point(260, 166);
            this.writerTitleLabel.Name = "writerTitleLabel";
            this.writerTitleLabel.Size = new System.Drawing.Size(102, 25);
            this.writerTitleLabel.TabIndex = 7;
            this.writerTitleLabel.Text = "Scenariusz";
            // 
            // writerLabel
            // 
            this.writerLabel.AutoSize = true;
            this.writerLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.writerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.writerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.writerLabel.Location = new System.Drawing.Point(261, 191);
            this.writerLabel.Name = "writerLabel";
            this.writerLabel.Size = new System.Drawing.Size(0, 21);
            this.writerLabel.TabIndex = 8;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genreLabel.Location = new System.Drawing.Point(261, 259);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(0, 21);
            this.genreLabel.TabIndex = 10;
            // 
            // genreTitleLabel
            // 
            this.genreTitleLabel.AutoSize = true;
            this.genreTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genreTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genreTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.genreTitleLabel.Location = new System.Drawing.Point(260, 234);
            this.genreTitleLabel.Name = "genreTitleLabel";
            this.genreTitleLabel.Size = new System.Drawing.Size(82, 25);
            this.genreTitleLabel.TabIndex = 9;
            this.genreTitleLabel.Text = "Gatunek";
            // 
            // wantToSeeCheckBox
            // 
            this.wantToSeeCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.wantToSeeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.wantToSeeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wantToSeeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wantToSeeCheckBox.ForeColor = System.Drawing.Color.White;
            this.wantToSeeCheckBox.Location = new System.Drawing.Point(259, 309);
            this.wantToSeeCheckBox.Name = "wantToSeeCheckBox";
            this.wantToSeeCheckBox.Size = new System.Drawing.Size(107, 29);
            this.wantToSeeCheckBox.TabIndex = 11;
            this.wantToSeeCheckBox.Text = "Chcę zobaczyć";
            this.wantToSeeCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wantToSeeCheckBox.UseVisualStyleBackColor = false;
            this.wantToSeeCheckBox.Click += new System.EventHandler(this.wantToSee_Click);
            // 
            // watchedCheckBox
            // 
            this.watchedCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.watchedCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.watchedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchedCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.watchedCheckBox.ForeColor = System.Drawing.Color.White;
            this.watchedCheckBox.Location = new System.Drawing.Point(382, 309);
            this.watchedCheckBox.Name = "watchedCheckBox";
            this.watchedCheckBox.Size = new System.Drawing.Size(107, 29);
            this.watchedCheckBox.TabIndex = 12;
            this.watchedCheckBox.Text = "Widziałem";
            this.watchedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.watchedCheckBox.UseVisualStyleBackColor = false;
            this.watchedCheckBox.Click += new System.EventHandler(this.watchedCheckBox_Click);
            // 
            // rateTitleLabel
            // 
            this.rateTitleLabel.AutoSize = true;
            this.rateTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rateTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rateTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.rateTitleLabel.Location = new System.Drawing.Point(260, 350);
            this.rateTitleLabel.Name = "rateTitleLabel";
            this.rateTitleLabel.Size = new System.Drawing.Size(133, 21);
            this.rateTitleLabel.TabIndex = 13;
            this.rateTitleLabel.Text = "Twoja ocena: brak";
            // 
            // rateTrackBar
            // 
            this.rateTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.rateTrackBar.Enabled = false;
            this.rateTrackBar.Location = new System.Drawing.Point(255, 374);
            this.rateTrackBar.Minimum = 1;
            this.rateTrackBar.Name = "rateTrackBar";
            this.rateTrackBar.Size = new System.Drawing.Size(278, 45);
            this.rateTrackBar.TabIndex = 15;
            this.rateTrackBar.Value = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(552, 368);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 29);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Zapisz ocenę";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backPictureBox
            // 
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPictureBox.Image = global::Movies.Properties.Resources.back;
            this.backPictureBox.Location = new System.Drawing.Point(648, 12);
            this.backPictureBox.Name = "backPictureBox";
            this.backPictureBox.Size = new System.Drawing.Size(24, 24);
            this.backPictureBox.TabIndex = 17;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.backPictureBox_Click);
            // 
            // noAverageLabel
            // 
            this.noAverageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.noAverageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.noAverageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.noAverageLabel.Location = new System.Drawing.Point(524, 135);
            this.noAverageLabel.Name = "noAverageLabel";
            this.noAverageLabel.Size = new System.Drawing.Size(88, 74);
            this.noAverageLabel.TabIndex = 19;
            this.noAverageLabel.Text = "brak ocen";
            this.noAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noAverageLabel.Visible = false;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoEllipsis = true;
            this.averageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.averageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.averageLabel.Location = new System.Drawing.Point(516, 136);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(103, 65);
            this.averageLabel.TabIndex = 20;
            this.averageLabel.Text = "3,34";
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(538, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "średnia ocen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Movies.Properties.Resources.circle;
            this.pictureBox1.Location = new System.Drawing.Point(491, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // userMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.noAverageLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backPictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.rateTrackBar);
            this.Controls.Add(this.rateTitleLabel);
            this.Controls.Add(this.watchedCheckBox);
            this.Controls.Add(this.wantToSeeCheckBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreTitleLabel);
            this.Controls.Add(this.writerLabel);
            this.Controls.Add(this.writerTitleLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.directorTitleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "userMovie";
            this.Text = "userMovie";
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionTitleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label directorTitleLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label writerTitleLabel;
        private System.Windows.Forms.Label writerLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label genreTitleLabel;
        private System.Windows.Forms.CheckBox wantToSeeCheckBox;
        private System.Windows.Forms.CheckBox watchedCheckBox;
        private System.Windows.Forms.Label rateTitleLabel;
        private System.Windows.Forms.TrackBar rateTrackBar;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox backPictureBox;
        private System.Windows.Forms.Label noAverageLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}