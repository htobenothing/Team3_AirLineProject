using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class LoginRegister
    {
        public bool CheckLoginUser(string name, string password)
        {
            bool isUserCorrect = false;
            AirlineEntities airlineEf = new AirlineEntities();
            User loginUser = airlineEf.Users.Find(name);
            if (null != loginUser)
            {
                if (loginUser.idUser == password)
                {
                    isUserCorrect = true;
                    return isUserCorrect;
                }
            }
            return isUserCorrect;
        }
    }
}
