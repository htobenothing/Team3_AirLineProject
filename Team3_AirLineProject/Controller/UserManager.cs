using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserManager
    {
        
        public static User getUser(string name)
        {
            using (AirlionEntities airlineEf = new AirlionEntities())
            {
                return airlineEf.Users.Find(name);
            }
            
        }

        public static void createUser(User newuser)
        {
            using (AirlionEntities airlineEf = new AirlionEntities())
            {
                airlineEf.Users.Add(newuser);
                airlineEf.SaveChanges();
            }
           
        }
    }
}
