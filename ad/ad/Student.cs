using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ad
{
    class Student
    {
        public string name;
        private string password;

        public void setPassword(string a)
        {
            password = a;
        }
   
        public bool getPassword(string b)
        {
            if (password == b)
            {
                return true;
            }
            return false;
        }
    }
    
}
