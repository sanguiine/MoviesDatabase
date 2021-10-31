namespace Movies
{
    partial class userRatingsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.errorLabel = new System.Windows.Forms.Label();
            this.watchedTitleLabel = new System.Windows.Forms.Label();
            this.watchedGridView = new System.Windows.Forms.DataGridView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ratingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.watchedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(12, 233);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 19;
            // 
            // watchedTitleLabel
            // 
            this.watchedTitleLabel.AutoSize = true;
            this.watchedTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.watchedTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.watchedTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.watchedTitleLabel.Location = new System.Drawing.Point(12, 22);
            this.watchedTitleLabel.Name = "watchedTitleLabel";
            this.watchedTitleLabel.Size = new System.Drawing.Size(196, 25);
            this.watchedTitleLabel.TabIndex = 18;
            this.watchedTitleLabel.Text = "Twoje obejrzane filmy";
            // 
            // watchedGridView
            // 
            this.watchedGridView.AllowUserToAddRows = false;
            this.watchedGridView.AllowUserToDeleteRows = false;
            this.watchedGridView.AllowUserToResizeColumns = false;
            this.watchedGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.watchedGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.watchedGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.watchedGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.watchedGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.watchedGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.watchedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchedGridView.ColumnHeadersVisible = false;
            this.watchedGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchedGridView.Location = new System.Drawing.Point(12, 233);
            this.watchedGridView.MultiSelect = false;
            this.watchedGridView.Name = "watchedGridView";
            this.watchedGridView.ReadOnly = true;
            this.watchedGridView.RowHeadersVisible = false;
            this.watchedGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.watchedGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.watchedGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.watchedGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.watchedGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            this.watchedGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.watchedGridView.RowTemplate.Height = 40;
            this.watchedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.watchedGridView.Size = new System.Drawing.Size(660, 316);
            this.watchedGridView.TabIndex = 17;
            this.watchedGridView.TabStop = false;
            this.watchedGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.watched_CellClick);
            this.watchedGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.watchedGridView_DataBindingComplete);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 561);
            this.mainPanel.TabIndex = 20;
            // 
            // ratingChart
            // 
            this.ratingChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Maximum = 10.9D;
            chartArea1.AxisX.Minimum = -1D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.ratingChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ratingChart.Legends.Add(legend1);
            this.ratingChart.Location = new System.Drawing.Point(12, 65);
            this.ratingChart.Name = "ratingChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(125)))), ((int)(((byte)(149)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.ratingChart.Series.Add(series1);
            this.ratingChart.Size = new System.Drawing.Size(634, 150);
            this.ratingChart.TabIndex = 21;
            this.ratingChart.Text = "chart1";
            // 
            // userRatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ratingChart);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.watchedTitleLabel);
            this.Controls.Add(this.watchedGridView);
            this.Controls.Add(this.mainPanel);
            this.Name = "userRatingsForm";
            this.Text = "userRatingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.watchedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label watchedTitleLabel;
        private System.Windows.Forms.DataGridView watchedGridView;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ratingChart;
    }
}