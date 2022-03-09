using System;
using System.Collections.Generic;
using System.Text;
using adoNetIntro;

namespace adoNetIntro
{
    public  class DbContext
    {
        public static string dataContext = null;
        public static string activeUser = null;
        public static List<User> users = new List<User>();
    }
}
