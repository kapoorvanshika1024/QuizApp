namespace Quiz.LeaderboardNS
{
    partial class Leaderboard
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
            this.leaderboard_label = new System.Windows.Forms.Label();
            this.result_dataGridView = new System.Windows.Forms.DataGridView();
            this.result_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.home_btn = new System.Windows.Forms.Button();
            this.review_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leaderboard_label
            // 
            this.leaderboard_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leaderboard_label.AutoSize = true;
            this.leaderboard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboard_label.Location = new System.Drawing.Point(439, 9);
            this.leaderboard_label.Name = "leaderboard_label";
            this.leaderboard_label.Size = new System.Drawing.Size(223, 39);
            this.leaderboard_label.TabIndex = 2;
            this.leaderboard_label.Text = "Leaderboard";
            // 
            // result_dataGridView
            // 
            this.result_dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.result_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.result_dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.result_dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.result_dataGridView.Location = new System.Drawing.Point(3, 3);
            this.result_dataGridView.MultiSelect = false;
            this.result_dataGridView.Name = "result_dataGridView";
            this.result_dataGridView.ReadOnly = true;
            this.result_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.result_dataGridView.Size = new System.Drawing.Size(352, 517);
            this.result_dataGridView.TabIndex = 3;
            this.result_dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.result_dataGridView_RowPrePaint);
            // 
            // result_chart
            // 
            this.result_chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.result_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.result_chart.Legends.Add(legend1);
            this.result_chart.Location = new System.Drawing.Point(3, 3);
            this.result_chart.Name = "result_chart";
            this.result_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.result_chart.Size = new System.Drawing.Size(708, 517);
            this.result_chart.TabIndex = 4;
            this.result_chart.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.result_dataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.result_chart);
            this.splitContainer1.Size = new System.Drawing.Size(1076, 523);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 5;
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(601, 602);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(75, 44);
            this.home_btn.TabIndex = 6;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // review_btn
            // 
            this.review_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_btn.Location = new System.Drawing.Point(424, 602);
            this.review_btn.Name = "review_btn";
            this.review_btn.Size = new System.Drawing.Size(135, 44);
            this.review_btn.TabIndex = 7;
            this.review_btn.Text = "Review Answers";
            this.review_btn.UseVisualStyleBackColor = true;
            this.review_btn.Click += new System.EventHandler(this.review_btn_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 658);
            this.Controls.Add(this.review_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.leaderboard_label);
            this.MaximizeBox = false;
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Leaderboard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_chart)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label leaderboard_label;
        private System.Windows.Forms.DataGridView result_dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart result_chart;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button review_btn;
    }
}