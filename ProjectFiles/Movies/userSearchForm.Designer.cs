namespace Movies
{
    partial class userSearchForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearDesc = new System.Windows.Forms.Button();
            this.yearAsc = new System.Windows.Forms.Button();
            this.nameDesc = new System.Windows.Forms.Button();
            this.sortLabel = new System.Windows.Forms.Label();
            this.nameAsc = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(568, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 27);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.titleTextBox.Location = new System.Drawing.Point(12, 50);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(346, 27);
            this.titleTextBox.TabIndex = 1;
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.AllowUserToDeleteRows = false;
            this.searchGridView.AllowUserToResizeColumns = false;
            this.searchGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.searchGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.searchGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.ColumnHeadersVisible = false;
            this.searchGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchGridView.Location = new System.Drawing.Point(12, 130);
            this.searchGridView.MultiSelect = false;
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.ReadOnly = true;
            this.searchGridView.RowHeadersVisible = false;
            this.searchGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.searchGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.searchGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.searchGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.searchGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.searchGridView.RowTemplate.Height = 40;
            this.searchGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchGridView.Size = new System.Drawing.Size(660, 419);
            this.searchGridView.TabIndex = 11;
            this.searchGridView.TabStop = false;
            this.searchGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_CellClick);
            this.searchGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.searchGridView_DataBindingComplete);
            // 
            // genreComboBox
            // 
            this.genreComboBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.genreComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "-"});
            this.genreComboBox.Location = new System.Drawing.Point(371, 50);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(184, 27);
            this.genreComboBox.TabIndex = 2;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(12, 130);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 15;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(52, 25);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Tytuł";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.genreLabel.Location = new System.Drawing.Point(371, 22);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(82, 25);
            this.genreLabel.TabIndex = 17;
            this.genreLabel.Text = "Gatunek";
            // 
            // yearDesc
            // 
            this.yearDesc.BackColor = System.Drawing.SystemColors.Control;
            this.yearDesc.FlatAppearance.BorderSize = 0;
            this.yearDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.yearDesc.Location = new System.Drawing.Point(402, 101);
            this.yearDesc.Name = "yearDesc";
            this.yearDesc.Size = new System.Drawing.Size(100, 23);
            this.yearDesc.TabIndex = 27;
            this.yearDesc.Text = "wg roku malejąco";
            this.yearDesc.UseVisualStyleBackColor = false;
            this.yearDesc.Click += new System.EventHandler(this.yearDesc_Click);
            // 
            // yearAsc
            // 
            this.yearAsc.BackColor = System.Drawing.SystemColors.Control;
            this.yearAsc.FlatAppearance.BorderSize = 0;
            this.yearAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.yearAsc.Location = new System.Drawing.Point(296, 101);
            this.yearAsc.Name = "yearAsc";
            this.yearAsc.Size = new System.Drawing.Size(100, 23);
            this.yearAsc.TabIndex = 26;
            this.yearAsc.Text = "wg roku rosnąco";
            this.yearAsc.UseVisualStyleBackColor = false;
            this.yearAsc.Click += new System.EventHandler(this.yearAsc_Click);
            // 
            // nameDesc
            // 
            this.nameDesc.BackColor = System.Drawing.SystemColors.Control;
            this.nameDesc.FlatAppearance.BorderSize = 0;
            this.nameDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.nameDesc.Location = new System.Drawing.Point(180, 101);
            this.nameDesc.Name = "nameDesc";
            this.nameDesc.Size = new System.Drawing.Size(110, 23);
            this.nameDesc.TabIndex = 25;
            this.nameDesc.Text = "wg nazwy malejąco";
            this.nameDesc.UseVisualStyleBackColor = false;
            this.nameDesc.Click += new System.EventHandler(this.nameDesc_Click);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sortLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.sortLabel.Location = new System.Drawing.Point(13, 103);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(45, 19);
            this.sortLabel.TabIndex = 24;
            this.sortLabel.Text = "Sortuj";
            // 
            // nameAsc
            // 
            this.nameAsc.BackColor = System.Drawing.SystemColors.Control;
            this.nameAsc.FlatAppearance.BorderSize = 0;
            this.nameAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.nameAsc.Location = new System.Drawing.Point(64, 101);
            this.nameAsc.Name = "nameAsc";
            this.nameAsc.Size = new System.Drawing.Size(110, 23);
            this.nameAsc.TabIndex = 23;
            this.nameAsc.Text = "wg nazwy rosnąco";
            this.nameAsc.UseVisualStyleBackColor = false;
            this.nameAsc.Click += new System.EventHandler(this.nameAsc_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 561);
            this.mainPanel.TabIndex = 28;
            // 
            // userSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.yearDesc);
            this.Controls.Add(this.yearAsc);
            this.Controls.Add(this.nameDesc);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.nameAsc);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.mainPanel);
            this.Name = "userSearchForm";
            this.Text = "userSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button yearDesc;
        private System.Windows.Forms.Button yearAsc;
        private System.Windows.Forms.Button nameDesc;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Button nameAsc;
        private System.Windows.Forms.Panel mainPanel;
    }
}