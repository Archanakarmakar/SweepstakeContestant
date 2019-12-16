using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    class User
    {
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string GetEmail()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }
        public static void DisplayConstestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.First_Name}");
            Console.WriteLine($"Last Name: {contestant.Last_Name}");
            Console.WriteLine($"Email: {contestant.Email_Address}");
            Console.WriteLine($"Registration Number: {contestant.Registration_Num}");
            Console.ReadLine();
        }

        //ask to pick a stack or queue
        public static string PickSweepstakesTypeManager()
        {
            Console.WriteLine("Do you want your sweepstakes manage by: stack or queue?");
            string userChoice = Console.ReadLine().ToString();
            return userChoice;
        }
  

    }
}

