using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginRegister.Views.User
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Name
            var uName = new TextBox();
            uName.Width = this.Width / 2;
            uName.Top = 20;
            uName.Left = this.Width/2 - uName.Width / 2;
            // Password
            var uPass = new TextBox();
            uPass.Width = this.Width / 2;
            uPass.Top = 20+uName.Height+10;
            uPass.Left = this.Width / 2 - uPass.Width / 2;
            // LoginBtn

            var loginBtn = new Button();

            loginBtn.Text = "Login";
            loginBtn.Top = uPass.Top + uPass.Height + 10;
            loginBtn.Left = this.Width / 2;
            
            // LoginBtn

            var registerBtn = new Button();
            
            registerBtn.Text = "Register";
            registerBtn.Top = uPass.Top + uPass.Height + 10;
            registerBtn.Left = this.Width / 2 - loginBtn.Width-20;
            registerBtn.Click += new EventHandler(this.showRegisterForm);
            this.Controls.Add(uName);
            this.Controls.Add(loginBtn);
            this.Controls.Add(registerBtn);
            this.Controls.Add(uPass);
        }
        public void showRegisterForm(object sender, EventArgs e)
        {
            var registerForm = new Register();
            
            var lbl = new Label();
            if(Data.DbContext.Users.Count>=1)
            {
                lbl.Text = Data.DbContext.Users[0].uName;
                registerForm.Controls.Add(lbl);
                registerForm.Show();
            }
            else
            {
                lbl.Text = "Hele hec kim elave edilmeyib";
                registerForm.Controls.Add(lbl);
                registerForm.Show();
            }
            
            

        }
    }
}
