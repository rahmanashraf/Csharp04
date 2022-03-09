using System;
using System.Collections.Generic;
using System.Text;

namespace adoNetIntro
{
    internal class UserController
    {
        public static void CreateUser(int _id,string _name,string _surname)
        {
            DbContext.users.Add(new User());
        }
    }
}
