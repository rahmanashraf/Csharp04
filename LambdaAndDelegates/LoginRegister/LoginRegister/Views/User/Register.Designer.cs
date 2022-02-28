namespace LoginRegister.Views.User
{
    partial class Register
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
            this.uName = new System.Windows.Forms.TextBox();
            this.uEmail = new System.Windows.Forms.TextBox();
            this.uPass = new System.Windows.Forms.TextBox();
            this.uPhone = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(263, 36);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(257, 23);
            this.uName.TabIndex = 0;
            // 
            // uEmail
            // 
            this.uEmail.Location = new System.Drawing.Point(263, 65);
            this.uEmail.Name = "uEmail";
            this.uEmail.Size = new System.Drawing.Size(257, 23);
            this.uEmail.TabIndex = 1;
            // 
            // uPass
            // 
            this.uPass.Location = new System.Drawing.Point(263, 94);
            this.uPass.Name = "uPass";
            this.uPass.Size = new System.Drawing.Size(257, 23);
            this.uPass.TabIndex = 2;
            // 
            // uPhone
            // 
            this.uPhone.Location = new System.Drawing.Point(263, 123);
            this.uPhone.Name = "uPhone";
            this.uPhone.Size = new System.Drawing.Size(257, 23);
            this.uPhone.TabIndex = 3;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(445, 152);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.getUserData);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.uPhone);
            this.Controls.Add(this.uPass);
            this.Controls.Add(this.uEmail);
            this.Controls.Add(this.uName);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox uName;
        public System.Windows.Forms.TextBox uEmail;
        public System.Windows.Forms.TextBox uPass;
        public System.Windows.Forms.TextBox uPhone;
        public System.Windows.Forms.Button registerBtn;
    }
}