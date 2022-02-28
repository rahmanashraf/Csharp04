using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace LoginRegister.Views.User
{
    public partial class Register : Form
    {
        

        public Register()
        {
            InitializeComponent();

        }

        private void getUserData(object sender, EventArgs e)
        {

            // Form elementlerinden datalarin alinmasi

            // Alinan datalara uygun user obyektinin yaradilmasi 

            // bu obyektin Users listini elave edilmesi
            var id = new Random();

            Data.DbContext.Users.Add(new Models.User()
            {
                uId = id.Next(1, 1000),
                uName = this.uName.Text,
                uEmail = this.uEmail.Text,
                uPassword = this.uPass.Text
            }
            );

            MessageBox.Show(Data.DbContext.Users[0].uId.ToString());

        }
    }
}
