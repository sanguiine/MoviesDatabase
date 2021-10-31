namespace Movies
{
    partial class adminUsersForm
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
            this.addTitleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editTitleLabel = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox2 = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTitleLabel
            // 
            this.addTitleLabel.AutoSize = true;
            this.addTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addTitleLabel.Location = new System.Drawing.Point(12, 22);
            this.addTitleLabel.Name = "addTitleLabel";
            this.addTitleLabel.Size = new System.Drawing.Size(171, 25);
            this.addTitleLabel.TabIndex = 24;
            this.addTitleLabel.Text = "Dodaj użytkownika";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameTextBox.Location = new System.Drawing.Point(79, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 25);
            this.nameTextBox.TabIndex = 19;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(568, 91);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 25);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameLabel.Location = new System.Drawing.Point(12, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 21);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Imię*";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.emailLabel.Location = new System.Drawing.Point(12, 90);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(55, 21);
            this.emailLabel.TabIndex = 26;
            this.emailLabel.Text = "Email*";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.emailTextBox.Location = new System.Drawing.Point(79, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(171, 25);
            this.emailTextBox.TabIndex = 27;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.passwordTextBox.Location = new System.Drawing.Point(362, 59);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(171, 25);
            this.passwordTextBox.TabIndex = 28;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.passwordLabel.Location = new System.Drawing.Point(270, 59);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 21);
            this.passwordLabel.TabIndex = 29;
            this.passwordLabel.Text = "Hasło*";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(13, 535);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(500, 17);
            this.errorLabel.TabIndex = 30;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(568, 454);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 25);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(568, 486);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 25);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeColumns = false;
            this.usersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.usersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersGridView.Location = new System.Drawing.Point(12, 141);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usersGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.usersGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.usersGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.usersGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.usersGridView.RowTemplate.Height = 40;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(660, 255);
            this.usersGridView.TabIndex = 40;
            this.usersGridView.TabStop = false;
            this.usersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_CellClick);
            this.usersGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.usersGridView_DataBindingComplete);
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.typeLabel.Location = new System.Drawing.Point(270, 91);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(84, 21);
            this.typeLabel.TabIndex = 41;
            this.typeLabel.Text = "Typ konta*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(270, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Typ konta*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(270, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nowe hasło";
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.passwordTextBox2.Location = new System.Drawing.Point(362, 454);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '●';
            this.passwordTextBox2.Size = new System.Drawing.Size(171, 25);
            this.passwordTextBox2.TabIndex = 48;
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.emailTextBox2.Location = new System.Drawing.Point(79, 485);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.Size = new System.Drawing.Size(171, 25);
            this.emailTextBox2.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(12, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Email*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(12, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Imię*";
            // 
            // editTitleLabel
            // 
            this.editTitleLabel.AutoSize = true;
            this.editTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.editTitleLabel.Location = new System.Drawing.Point(12, 417);
            this.editTitleLabel.Name = "editTitleLabel";
            this.editTitleLabel.Size = new System.Drawing.Size(216, 25);
            this.editTitleLabel.TabIndex = 44;
            this.editTitleLabel.Text = "Edytuj użytkownika o ID:";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nameTextBox2.Location = new System.Drawing.Point(79, 454);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(171, 25);
            this.nameTextBox2.TabIndex = 43;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.typeComboBox.Location = new System.Drawing.Point(362, 91);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(171, 25);
            this.typeComboBox.TabIndex = 52;
            // 
            // typeComboBox2
            // 
            this.typeComboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.typeComboBox2.FormattingEnabled = true;
            this.typeComboBox2.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.typeComboBox2.Location = new System.Drawing.Point(362, 486);
            this.typeComboBox2.Name = "typeComboBox2";
            this.typeComboBox2.Size = new System.Drawing.Size(171, 25);
            this.typeComboBox2.TabIndex = 53;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.idLabel.Location = new System.Drawing.Point(234, 417);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(49, 25);
            this.idLabel.TabIndex = 55;
            this.idLabel.Text = "brak";
            // 
            // adminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.typeComboBox2);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.emailTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.editTitleLabel);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.usersGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addTitleLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "adminUsersForm";
            this.Text = "adminUsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label addTitleLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox emailTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label editTitleLabel;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox typeComboBox2;
        private System.Windows.Forms.Label idLabel;
    }
}