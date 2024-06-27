using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    partial class Intro
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.gameType_box = new Quiz_Game.SelectGameType();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.welcome_label.Location = new System.Drawing.Point(12, 87);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(776, 52);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to Quiz";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(350, 331);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(100, 34);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // gameType_box
            // 
            this.gameType_box.Location = new System.Drawing.Point(245, 212);
            this.gameType_box.Name = "gameType_box";
            this.gameType_box.Size = new System.Drawing.Size(310, 62);
            this.gameType_box.TabIndex = 2;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameType_box);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.welcome_label);
            this.MinimizeBox = false;
            this.Name = "Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Intro_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Label welcome_label;
        private Button start_btn;
        private Quiz_Game.SelectGameType gameType_box;
    }
}

