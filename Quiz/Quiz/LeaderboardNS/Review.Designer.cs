namespace Quiz.LeaderboardNS
{
    partial class Review
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
            this.review_dataGridView = new System.Windows.Forms.DataGridView();
            this.score_label = new System.Windows.Forms.Label();
            this.winning_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.review_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // review_dataGridView
            // 
            this.review_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.review_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.review_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.review_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.review_dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.review_dataGridView.Location = new System.Drawing.Point(12, 60);
            this.review_dataGridView.MultiSelect = false;
            this.review_dataGridView.Name = "review_dataGridView";
            this.review_dataGridView.ReadOnly = true;
            this.review_dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.review_dataGridView.Size = new System.Drawing.Size(776, 413);
            this.review_dataGridView.TabIndex = 0;
            this.review_dataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.review_dataGridView_RowPrePaint);
            // 
            // score_label
            // 
            this.score_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.Location = new System.Drawing.Point(68, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(181, 39);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Score = 9/10";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winning_label
            // 
            this.winning_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.winning_label.AutoSize = true;
            this.winning_label.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winning_label.Location = new System.Drawing.Point(435, 9);
            this.winning_label.Name = "winning_label";
            this.winning_label.Size = new System.Drawing.Size(297, 39);
            this.winning_label.TabIndex = 2;
            this.winning_label.Text = "Winning(%) = 98.49%";
            this.winning_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.winning_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.review_dataGridView);
            this.MinimizeBox = false;
            this.Name = "Review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            ((System.ComponentModel.ISupportInitialize)(this.review_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView review_dataGridView;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label winning_label;
    }
}