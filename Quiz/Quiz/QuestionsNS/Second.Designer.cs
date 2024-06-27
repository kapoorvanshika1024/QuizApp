namespace Quiz.Second
{
    partial class Second
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
            this.components = new System.ComponentModel.Container();
            this.Q_label = new System.Windows.Forms.Label();
            this.question_textBox = new System.Windows.Forms.TextBox();
            this.timer_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.A_radioButton = new System.Windows.Forms.RadioButton();
            this.B_radioButton = new System.Windows.Forms.RadioButton();
            this.C_radioButton = new System.Windows.Forms.RadioButton();
            this.D_radioButton = new System.Windows.Forms.RadioButton();
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Q_label
            // 
            this.Q_label.AutoSize = true;
            this.Q_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q_label.Location = new System.Drawing.Point(12, 25);
            this.Q_label.Name = "Q_label";
            this.Q_label.Size = new System.Drawing.Size(151, 24);
            this.Q_label.TabIndex = 0;
            this.Q_label.Text = "Question 0 of 0";
            // 
            // question_textBox
            // 
            this.question_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_textBox.Location = new System.Drawing.Point(16, 52);
            this.question_textBox.Multiline = true;
            this.question_textBox.Name = "question_textBox";
            this.question_textBox.ReadOnly = true;
            this.question_textBox.ShortcutsEnabled = false;
            this.question_textBox.Size = new System.Drawing.Size(772, 55);
            this.question_textBox.TabIndex = 1;
            this.question_textBox.TabStop = false;
            this.question_textBox.Text = "Question";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(423, 219);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(277, 37);
            this.timer_label.TabIndex = 2;
            this.timer_label.Text = "Getting Started...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // A_radioButton
            // 
            this.A_radioButton.AutoSize = true;
            this.A_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_radioButton.Location = new System.Drawing.Point(16, 154);
            this.A_radioButton.Name = "A_radioButton";
            this.A_radioButton.Size = new System.Drawing.Size(93, 28);
            this.A_radioButton.TabIndex = 3;
            this.A_radioButton.Text = "Options";
            this.A_radioButton.UseVisualStyleBackColor = true;
            // 
            // B_radioButton
            // 
            this.B_radioButton.AutoSize = true;
            this.B_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_radioButton.Location = new System.Drawing.Point(16, 216);
            this.B_radioButton.Name = "B_radioButton";
            this.B_radioButton.Size = new System.Drawing.Size(93, 28);
            this.B_radioButton.TabIndex = 4;
            this.B_radioButton.Text = "Options";
            this.B_radioButton.UseVisualStyleBackColor = true;
            // 
            // C_radioButton
            // 
            this.C_radioButton.AutoSize = true;
            this.C_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_radioButton.Location = new System.Drawing.Point(16, 278);
            this.C_radioButton.Name = "C_radioButton";
            this.C_radioButton.Size = new System.Drawing.Size(93, 28);
            this.C_radioButton.TabIndex = 5;
            this.C_radioButton.Text = "Options";
            this.C_radioButton.UseVisualStyleBackColor = true;
            // 
            // D_radioButton
            // 
            this.D_radioButton.AutoSize = true;
            this.D_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_radioButton.Location = new System.Drawing.Point(16, 340);
            this.D_radioButton.Name = "D_radioButton";
            this.D_radioButton.Size = new System.Drawing.Size(93, 28);
            this.D_radioButton.TabIndex = 6;
            this.D_radioButton.Text = "Options";
            this.D_radioButton.UseVisualStyleBackColor = true;
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(602, 345);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(109, 23);
            this.next_button.TabIndex = 7;
            this.next_button.Text = "Next Question";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.D_radioButton);
            this.Controls.Add(this.C_radioButton);
            this.Controls.Add(this.B_radioButton);
            this.Controls.Add(this.A_radioButton);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.question_textBox);
            this.Controls.Add(this.Q_label);
            this.Name = "Second";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Second_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Q_label;
        private System.Windows.Forms.TextBox question_textBox;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton A_radioButton;
        private System.Windows.Forms.RadioButton B_radioButton;
        private System.Windows.Forms.RadioButton C_radioButton;
        private System.Windows.Forms.RadioButton D_radioButton;
        private System.Windows.Forms.Button next_button;
    }
}