using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LoginRegister
    {
        public static bool CheckLoginUser(string name, string password)
        {
            bool isUserCorrect = false;
            
            User loginUser = UserManager.getUser(name);
            if (null != loginUser)
            {
                if(loginUser.status.ToLower() == "active")
                {
                    if (loginUser.password.Equals(password))
                    {

                        isUserCorrect = true;
                        return isUserCorrect;
                    }
                }
                
            }
            return isUserCorrect;
        }

        public static bool CheckUserid(string name)
        {
            bool isUserExit = false;
            if (UserManager.getUser(name) == null)
            {
                isUserExit = true;
                return isUserExit;
            }

            return isUserExit;
        }
        public static bool RegisterUser(string name, string password, string phoneNo)
        {
            if (UserManager.getUser(name) == null)
            {
                User newUser = new User();
                newUser.idUser = name;
                newUser.password = password;
                newUser.phoneNo = phoneNo;
                newUser.status = "active";
                newUser.idRole = "user";
                
                UserManager.createUser(newUser);
                return true;
            }
            else
            {
                return false;
            }
           


        }

    }
    
    
}
