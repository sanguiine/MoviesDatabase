namespace Movies
{
    partial class userWantToSeeForm
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
            this.wantToSeeGridView = new System.Windows.Forms.DataGridView();
            this.wantToSeeTitleLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wantToSeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wantToSeeGridView
            // 
            this.wantToSeeGridView.AllowUserToAddRows = false;
            this.wantToSeeGridView.AllowUserToDeleteRows = false;
            this.wantToSeeGridView.AllowUserToResizeColumns = false;
            this.wantToSeeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.wantToSeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.wantToSeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wantToSeeGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.wantToSeeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wantToSeeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.wantToSeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wantToSeeGridView.ColumnHeadersVisible = false;
            this.wantToSeeGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wantToSeeGridView.Location = new System.Drawing.Point(12, 73);
            this.wantToSeeGridView.MultiSelect = false;
            this.wantToSeeGridView.Name = "wantToSeeGridView";
            this.wantToSeeGridView.ReadOnly = true;
            this.wantToSeeGridView.RowHeadersVisible = false;
            this.wantToSeeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.wantToSeeGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.wantToSeeGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wantToSeeGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.wantToSeeGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.wantToSeeGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.wantToSeeGridView.RowTemplate.Height = 40;
            this.wantToSeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wantToSeeGridView.Size = new System.Drawing.Size(660, 476);
            this.wantToSeeGridView.TabIndex = 12;
            this.wantToSeeGridView.TabStop = false;
            this.wantToSeeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wantToSee_CellClick);
            this.wantToSeeGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.wantToSeeGridView_DataBindingComplete);
            // 
            // wantToSeeTitleLabel
            // 
            this.wantToSeeTitleLabel.AutoSize = true;
            this.wantToSeeTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.wantToSeeTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wantToSeeTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.wantToSeeTitleLabel.Location = new System.Drawing.Point(12, 22);
            this.wantToSeeTitleLabel.Name = "wantToSeeTitleLabel";
            this.wantToSeeTitleLabel.Size = new System.Drawing.Size(251, 25);
            this.wantToSeeTitleLabel.TabIndex = 13;
            this.wantToSeeTitleLabel.Text = "Filmy, które chcesz zobaczyć";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(12, 65);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 16;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 561);
            this.mainPanel.TabIndex = 29;
            // 
            // userWantToSeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.wantToSeeTitleLabel);
            this.Controls.Add(this.wantToSeeGridView);
            this.Controls.Add(this.mainPanel);
            this.Name = "userWantToSeeForm";
            this.Text = "userWantToSeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.wantToSeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView wantToSeeGridView;
        private System.Windows.Forms.Label wantToSeeTitleLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel mainPanel;
    }
}