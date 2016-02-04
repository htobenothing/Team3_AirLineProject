using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Test
    {
        static void Main()
        {
            LoginRegister lg = new LoginRegister();

            Console.WriteLine(LoginRegister.CheckLoginUser("jame1@gmail.com","123456"));
            
        }
    }
}
