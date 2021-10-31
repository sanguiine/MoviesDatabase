namespace Movies
{
    partial class adminGenresForm
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
            this.editTitleLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addTitleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.genresComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.addGenreLabel = new System.Windows.Forms.Label();
            this.addButton2 = new System.Windows.Forms.Button();
            this.genresComboBox2 = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreLabel2 = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieLabel2 = new System.Windows.Forms.Label();
            this.genreLabel3 = new System.Windows.Forms.Label();
            this.genresComboBox3 = new System.Windows.Forms.ComboBox();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.movieComboBox2 = new System.Windows.Forms.ComboBox();
            this.deleteGenreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editTitleLabel
            // 
            this.editTitleLabel.AutoSize = true;
            this.editTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.editTitleLabel.Location = new System.Drawing.Point(12, 125);
            this.editTitleLabel.Name = "editTitleLabel";
            this.editTitleLabel.Size = new System.Drawing.Size(137, 25);
            this.editTitleLabel.TabIndex = 70;
            this.editTitleLabel.Text = "Edytuj gatunek";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(279, 190);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 25);
            this.deleteButton.TabIndex = 66;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(279, 159);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 25);
            this.editButton.TabIndex = 65;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 535);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(500, 17);
            this.errorLabel.TabIndex = 64;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameLabel.Location = new System.Drawing.Point(13, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 21);
            this.nameLabel.TabIndex = 59;
            this.nameLabel.Text = "Nazwa*";
            // 
            // addTitleLabel
            // 
            this.addTitleLabel.AutoSize = true;
            this.addTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addTitleLabel.Location = new System.Drawing.Point(12, 22);
            this.addTitleLabel.Name = "addTitleLabel";
            this.addTitleLabel.Size = new System.Drawing.Size(135, 25);
            this.addTitleLabel.TabIndex = 58;
            this.addTitleLabel.Text = "Dodaj gatunek";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameTextBox.Location = new System.Drawing.Point(89, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 25);
            this.nameTextBox.TabIndex = 56;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(279, 60);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 25);
            this.addButton.TabIndex = 57;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // genresComboBox
            // 
            this.genresComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genresComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Items.AddRange(new object[] {
            "-"});
            this.genresComboBox.Location = new System.Drawing.Point(89, 159);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(171, 25);
            this.genresComboBox.TabIndex = 81;
            this.genresComboBox.SelectedIndexChanged += new System.EventHandler(this.genresComboBox_SelectedIndexChanged);
            // 
            // nameLabel2
            // 
            this.nameLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameLabel2.Location = new System.Drawing.Point(13, 191);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(64, 21);
            this.nameLabel2.TabIndex = 83;
            this.nameLabel2.Text = "Nazwa*";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameTextBox2.Location = new System.Drawing.Point(89, 190);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(171, 25);
            this.nameTextBox2.TabIndex = 82;
            // 
            // movieComboBox
            // 
            this.movieComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.movieComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Items.AddRange(new object[] {
            "-"});
            this.movieComboBox.Location = new System.Drawing.Point(89, 284);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(294, 25);
            this.movieComboBox.TabIndex = 87;
            // 
            // addGenreLabel
            // 
            this.addGenreLabel.AutoSize = true;
            this.addGenreLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addGenreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addGenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addGenreLabel.Location = new System.Drawing.Point(12, 250);
            this.addGenreLabel.Name = "addGenreLabel";
            this.addGenreLabel.Size = new System.Drawing.Size(210, 25);
            this.addGenreLabel.TabIndex = 86;
            this.addGenreLabel.Text = "Dodaj gatunek do filmu";
            // 
            // addButton2
            // 
            this.addButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton2.FlatAppearance.BorderSize = 0;
            this.addButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton2.ForeColor = System.Drawing.Color.White;
            this.addButton2.Location = new System.Drawing.Point(279, 314);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(104, 25);
            this.addButton2.TabIndex = 90;
            this.addButton2.Text = "Dodaj";
            this.addButton2.UseVisualStyleBackColor = false;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // genresComboBox2
            // 
            this.genresComboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genresComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genresComboBox2.FormattingEnabled = true;
            this.genresComboBox2.Items.AddRange(new object[] {
            "-"});
            this.genresComboBox2.Location = new System.Drawing.Point(89, 315);
            this.genresComboBox2.Name = "genresComboBox2";
            this.genresComboBox2.Size = new System.Drawing.Size(171, 25);
            this.genresComboBox2.TabIndex = 91;
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genreLabel.Location = new System.Drawing.Point(13, 159);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(75, 21);
            this.genreLabel.TabIndex = 92;
            this.genreLabel.Text = "Gatunek*";
            // 
            // genreLabel2
            // 
            this.genreLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genreLabel2.AutoSize = true;
            this.genreLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.genreLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genreLabel2.Location = new System.Drawing.Point(13, 315);
            this.genreLabel2.Name = "genreLabel2";
            this.genreLabel2.Size = new System.Drawing.Size(75, 21);
            this.genreLabel2.TabIndex = 93;
            this.genreLabel2.Text = "Gatunek*";
            // 
            // movieLabel
            // 
            this.movieLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.movieLabel.Location = new System.Drawing.Point(13, 284);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(47, 21);
            this.movieLabel.TabIndex = 94;
            this.movieLabel.Text = "Film*";
            // 
            // movieLabel2
            // 
            this.movieLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.movieLabel2.AutoSize = true;
            this.movieLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.movieLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.movieLabel2.Location = new System.Drawing.Point(13, 411);
            this.movieLabel2.Name = "movieLabel2";
            this.movieLabel2.Size = new System.Drawing.Size(47, 21);
            this.movieLabel2.TabIndex = 100;
            this.movieLabel2.Text = "Film*";
            // 
            // genreLabel3
            // 
            this.genreLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.genreLabel3.AutoSize = true;
            this.genreLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.genreLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genreLabel3.Location = new System.Drawing.Point(13, 442);
            this.genreLabel3.Name = "genreLabel3";
            this.genreLabel3.Size = new System.Drawing.Size(75, 21);
            this.genreLabel3.TabIndex = 99;
            this.genreLabel3.Text = "Gatunek*";
            // 
            // genresComboBox3
            // 
            this.genresComboBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genresComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genresComboBox3.FormattingEnabled = true;
            this.genresComboBox3.Items.AddRange(new object[] {
            "-"});
            this.genresComboBox3.Location = new System.Drawing.Point(89, 442);
            this.genresComboBox3.Name = "genresComboBox3";
            this.genresComboBox3.Size = new System.Drawing.Size(171, 25);
            this.genresComboBox3.TabIndex = 98;
            // 
            // deleteButton2
            // 
            this.deleteButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.deleteButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton2.FlatAppearance.BorderSize = 0;
            this.deleteButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteButton2.ForeColor = System.Drawing.Color.White;
            this.deleteButton2.Location = new System.Drawing.Point(279, 441);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(104, 25);
            this.deleteButton2.TabIndex = 97;
            this.deleteButton2.Text = "Usuń";
            this.deleteButton2.UseVisualStyleBackColor = false;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // movieComboBox2
            // 
            this.movieComboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.movieComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.movieComboBox2.FormattingEnabled = true;
            this.movieComboBox2.Items.AddRange(new object[] {
            "-"});
            this.movieComboBox2.Location = new System.Drawing.Point(89, 411);
            this.movieComboBox2.Name = "movieComboBox2";
            this.movieComboBox2.Size = new System.Drawing.Size(294, 25);
            this.movieComboBox2.TabIndex = 96;
            this.movieComboBox2.SelectedIndexChanged += new System.EventHandler(this.movieComboBox2_SelectedIndexChanged);
            // 
            // deleteGenreLabel
            // 
            this.deleteGenreLabel.AutoSize = true;
            this.deleteGenreLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteGenreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteGenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.deleteGenreLabel.Location = new System.Drawing.Point(12, 377);
            this.deleteGenreLabel.Name = "deleteGenreLabel";
            this.deleteGenreLabel.Size = new System.Drawing.Size(190, 25);
            this.deleteGenreLabel.TabIndex = 95;
            this.deleteGenreLabel.Text = "Usuń gatunek z filmu";
            // 
            // adminGenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.movieLabel2);
            this.Controls.Add(this.genreLabel3);
            this.Controls.Add(this.genresComboBox3);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.movieComboBox2);
            this.Controls.Add(this.deleteGenreLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.genreLabel2);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genresComboBox2);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.addGenreLabel);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.genresComboBox);
            this.Controls.Add(this.editTitleLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addTitleLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "adminGenresForm";
            this.Text = "adminGenresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label editTitleLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addTitleLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox genresComboBox;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.Label addGenreLabel;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.ComboBox genresComboBox2;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label genreLabel2;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label movieLabel2;
        private System.Windows.Forms.Label genreLabel3;
        private System.Windows.Forms.ComboBox genresComboBox3;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.ComboBox movieComboBox2;
        private System.Windows.Forms.Label deleteGenreLabel;
    }
}