namespace Quiz.UserSignInNS
{
    partial class ForgotPassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.signin_label = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Forgot Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(107, 60);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(192, 20);
            this.name_textBox.TabIndex = 1;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(107, 86);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(192, 20);
            this.email_textBox.TabIndex = 2;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(107, 115);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(192, 20);
            this.phone_textBox.TabIndex = 3;
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.Location = new System.Drawing.Point(132, 228);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(107, 13);
            this.signin_label.TabIndex = 6;
            this.signin_label.Text = "Already user? Sign In";
            this.signin_label.Click += new System.EventHandler(this.signin_label_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(109, 183);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(153, 31);
            this.reset_button.TabIndex = 5;
            this.reset_button.Text = "Search";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(107, 141);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '#';
            this.pass_textBox.Size = new System.Drawing.Size(192, 20);
            this.pass_textBox.TabIndex = 12;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(23, 144);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(78, 13);
            this.pass_label.TabIndex = 13;
            this.pass_label.Text = "New Password";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 260);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.signin_label);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fogot Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ForgotPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label signin_label;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Label pass_label;
    }
}