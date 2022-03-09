using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace adoNetIntro
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var txt = textBox1.Text;
            DbContext.dataContext = txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserList().Show();
        }
    }
}
