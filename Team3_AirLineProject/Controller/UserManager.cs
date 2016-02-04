using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class UserManager
    {
        static AirlineEntities airlineEf = new AirlineEntities();
        public static User getUser(string name)
        {
            
            return airlineEf.Users.Find(name);
        }

        public static void createUser(User newuser)
        {
            airlineEf.Users.Add(newuser);

        }
    }
}
