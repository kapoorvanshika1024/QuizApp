namespace Quiz.UserSignInNS
{
    partial class SignUp
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
            this.label5 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.signin_label = new System.Windows.Forms.Label();
            this.signup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sign Up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(97, 60);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(192, 20);
            this.name_textBox.TabIndex = 1;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(97, 86);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(192, 20);
            this.email_textBox.TabIndex = 2;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(97, 115);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(192, 20);
            this.phone_textBox.TabIndex = 3;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(97, 141);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '#';
            this.pass_textBox.Size = new System.Drawing.Size(192, 20);
            this.pass_textBox.TabIndex = 4;
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.Location = new System.Drawing.Point(122, 228);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(107, 13);
            this.signin_label.TabIndex = 6;
            this.signin_label.Text = "Already user? Sign In";
            this.signin_label.Click += new System.EventHandler(this.signin_label_Click);
            // 
            // signup_button
            // 
            this.signup_button.Location = new System.Drawing.Point(99, 183);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(153, 31);
            this.signup_button.TabIndex = 5;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 260);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.signin_label);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Label signin_label;
        private System.Windows.Forms.Button signup_button;
    }
}