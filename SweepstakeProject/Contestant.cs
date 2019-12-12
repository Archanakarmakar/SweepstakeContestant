using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    public class Contestant
    {
        public string first_name;
        public string last_name;
        public string email_address;
        public  int registration_number;
        Contestant()
        {

        }
        Contestant(string first_name, string last_name, string email_address, int registration_number)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email_address = email_address;
            this.registration_number = registration_number;
        }
    }
}
