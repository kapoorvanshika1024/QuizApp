namespace Quiz.UserLoginNS
{
    partial class SignIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.signin_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_label = new System.Windows.Forms.Label();
            this.forgot_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail or Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(125, 76);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(198, 20);
            this.email_textBox.TabIndex = 2;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(125, 106);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '#';
            this.pass_textBox.Size = new System.Drawing.Size(198, 20);
            this.pass_textBox.TabIndex = 3;
            // 
            // signin_button
            // 
            this.signin_button.Location = new System.Drawing.Point(40, 141);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(283, 31);
            this.signin_button.TabIndex = 4;
            this.signin_button.Text = "Sign In";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign In";
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Location = new System.Drawing.Point(224, 190);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(99, 13);
            this.signup_label.TabIndex = 5;
            this.signup_label.Text = "New user? Sign Up";
            this.signup_label.Click += new System.EventHandler(this.signup_label_Click);
            // 
            // forgot_label
            // 
            this.forgot_label.AutoSize = true;
            this.forgot_label.Location = new System.Drawing.Point(37, 190);
            this.forgot_label.Name = "forgot_label";
            this.forgot_label.Size = new System.Drawing.Size(92, 13);
            this.forgot_label.TabIndex = 6;
            this.forgot_label.Text = "Forgot Password?";
            this.forgot_label.Click += new System.EventHandler(this.forgot_label_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 247);
            this.Controls.Add(this.forgot_label);
            this.Controls.Add(this.signup_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label signup_label;
        private System.Windows.Forms.Label forgot_label;
    }
}