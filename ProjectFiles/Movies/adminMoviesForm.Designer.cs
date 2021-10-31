namespace Movies
{
    partial class adminMoviesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addTitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addPosterButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.moviesGridView = new System.Windows.Forms.DataGridView();
            this.changePosterButton = new System.Windows.Forms.Button();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.descriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.posterPictureBox2 = new System.Windows.Forms.PictureBox();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.posterLabel = new System.Windows.Forms.Label();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(125, 487);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 25);
            this.deleteButton.TabIndex = 107;
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
            this.editButton.Location = new System.Drawing.Point(15, 487);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 25);
            this.editButton.TabIndex = 106;
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
            this.errorLabel.TabIndex = 105;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(15, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 25);
            this.addButton.TabIndex = 102;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 90);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(49, 21);
            this.descriptionLabel.TabIndex = 119;
            this.descriptionLabel.Text = "Opis*";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(89, 90);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(268, 60);
            this.descriptionTextBox.TabIndex = 125;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dateLabel.Location = new System.Drawing.Point(10, 156);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 21);
            this.dateLabel.TabIndex = 126;
            this.dateLabel.Text = "Premiera*";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(89, 156);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(113, 25);
            this.dateTimePicker.TabIndex = 127;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.titleLabel.Location = new System.Drawing.Point(13, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 21);
            this.titleLabel.TabIndex = 130;
            this.titleLabel.Text = "Tytuł*";
            // 
            // addTitleLabel
            // 
            this.addTitleLabel.AutoSize = true;
            this.addTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addTitleLabel.Location = new System.Drawing.Point(12, 22);
            this.addTitleLabel.Name = "addTitleLabel";
            this.addTitleLabel.Size = new System.Drawing.Size(99, 25);
            this.addTitleLabel.TabIndex = 129;
            this.addTitleLabel.Text = "Dodaj film";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.titleTextBox.Location = new System.Drawing.Point(89, 59);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(268, 25);
            this.titleTextBox.TabIndex = 128;
            // 
            // addPosterButton
            // 
            this.addPosterButton.Location = new System.Drawing.Point(88, 185);
            this.addPosterButton.Name = "addPosterButton";
            this.addPosterButton.Size = new System.Drawing.Size(115, 25);
            this.addPosterButton.TabIndex = 131;
            this.addPosterButton.Text = "Dodaj plakat";
            this.addPosterButton.UseVisualStyleBackColor = true;
            this.addPosterButton.Click += new System.EventHandler(this.addPosterButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All files (*.*)|*.*";
            this.openFileDialog.Title = "Wybierz plik z plakatem";
            // 
            // moviesGridView
            // 
            this.moviesGridView.AllowUserToAddRows = false;
            this.moviesGridView.AllowUserToDeleteRows = false;
            this.moviesGridView.AllowUserToResizeColumns = false;
            this.moviesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.moviesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.moviesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moviesGridView.BackgroundColor = System.Drawing.Color.White;
            this.moviesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moviesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moviesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.moviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moviesGridView.Location = new System.Drawing.Point(378, 59);
            this.moviesGridView.MultiSelect = false;
            this.moviesGridView.Name = "moviesGridView";
            this.moviesGridView.ReadOnly = true;
            this.moviesGridView.RowHeadersVisible = false;
            this.moviesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.moviesGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.moviesGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moviesGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.moviesGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.moviesGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.moviesGridView.RowTemplate.Height = 40;
            this.moviesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.moviesGridView.Size = new System.Drawing.Size(294, 453);
            this.moviesGridView.TabIndex = 132;
            this.moviesGridView.TabStop = false;
            this.moviesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesGridView_CellClick);
            this.moviesGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.moviesGridView_DataBindingComplete);
            // 
            // changePosterButton
            // 
            this.changePosterButton.Location = new System.Drawing.Point(88, 437);
            this.changePosterButton.Name = "changePosterButton";
            this.changePosterButton.Size = new System.Drawing.Size(115, 25);
            this.changePosterButton.TabIndex = 141;
            this.changePosterButton.Text = "Zmień plakat";
            this.changePosterButton.UseVisualStyleBackColor = true;
            this.changePosterButton.Click += new System.EventHandler(this.changePosterButton_Click);
            // 
            // titleLabel2
            // 
            this.titleLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.titleLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.titleLabel2.Location = new System.Drawing.Point(13, 312);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(50, 21);
            this.titleLabel2.TabIndex = 140;
            this.titleLabel2.Text = "Tytuł*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "Edytuj film";
            // 
            // titleTextBox2
            // 
            this.titleTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.titleTextBox2.Location = new System.Drawing.Point(89, 311);
            this.titleTextBox2.Name = "titleTextBox2";
            this.titleTextBox2.Size = new System.Drawing.Size(268, 25);
            this.titleTextBox2.TabIndex = 138;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(89, 408);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 25);
            this.dateTimePicker2.TabIndex = 137;
            // 
            // dateLabel2
            // 
            this.dateLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dateLabel2.Location = new System.Drawing.Point(10, 410);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(80, 21);
            this.dateLabel2.TabIndex = 136;
            this.dateLabel2.Text = "Premiera*";
            // 
            // descriptionTextBox2
            // 
            this.descriptionTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.descriptionTextBox2.Location = new System.Drawing.Point(89, 342);
            this.descriptionTextBox2.Multiline = true;
            this.descriptionTextBox2.Name = "descriptionTextBox2";
            this.descriptionTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox2.Size = new System.Drawing.Size(268, 60);
            this.descriptionTextBox2.TabIndex = 135;
            // 
            // posterPictureBox2
            // 
            this.posterPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.posterPictureBox2.Location = new System.Drawing.Point(275, 408);
            this.posterPictureBox2.Name = "posterPictureBox2";
            this.posterPictureBox2.Size = new System.Drawing.Size(82, 104);
            this.posterPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterPictureBox2.TabIndex = 134;
            this.posterPictureBox2.TabStop = false;
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.descriptionLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.descriptionLabel2.Location = new System.Drawing.Point(13, 342);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(49, 21);
            this.descriptionLabel2.TabIndex = 133;
            this.descriptionLabel2.Text = "Opis*";
            // 
            // posterLabel
            // 
            this.posterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.posterLabel.AutoSize = true;
            this.posterLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.posterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.posterLabel.Location = new System.Drawing.Point(10, 437);
            this.posterLabel.Name = "posterLabel";
            this.posterLabel.Size = new System.Drawing.Size(52, 21);
            this.posterLabel.TabIndex = 142;
            this.posterLabel.Text = "Plakat";
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.posterPictureBox.Location = new System.Drawing.Point(275, 156);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(82, 102);
            this.posterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posterPictureBox.TabIndex = 143;
            this.posterPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(10, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 144;
            this.label1.Text = "Plakat";
            // 
            // adminMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posterPictureBox);
            this.Controls.Add(this.posterLabel);
            this.Controls.Add(this.changePosterButton);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTextBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.descriptionTextBox2);
            this.Controls.Add(this.posterPictureBox2);
            this.Controls.Add(this.descriptionLabel2);
            this.Controls.Add(this.moviesGridView);
            this.Controls.Add(this.addPosterButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addTitleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addButton);
            this.Name = "adminMoviesForm";
            this.Text = "adminMoviesForm";
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label addTitleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button addPosterButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView moviesGridView;
        private System.Windows.Forms.Button changePosterButton;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.TextBox descriptionTextBox2;
        private System.Windows.Forms.PictureBox posterPictureBox2;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label posterLabel;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Label label1;
    }
}