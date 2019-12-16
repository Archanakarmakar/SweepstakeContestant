using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    public class Contestant
    {
        public Contestant()
        {
            First_Name = User.GetFirstName();
            Last_Name = User.GetLastName();
            Email_Address = User.GetEmail();
           
        }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Address { get; set; }
        public int Registration_Num { get; set; }

    }
}
