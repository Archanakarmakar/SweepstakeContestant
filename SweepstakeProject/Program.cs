using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name = "John";
            Sweepstakes sweepstakes = new Sweepstakes(name);
            Contestant contestant = new Contestant();
            contestant.Email_Address = "abcd@something.com";
            contestant.First_Name = "John";
            contestant.Last_Name = "Jordan";
            sweepstakes.RegisterContestant(contestant);
            Contestant contestant1 = new Contestant();
            contestant1.Email_Address= "arcy@something.com";
            contestant1.First_Name = "foo";
            contestant1.Last_Name = "Loo";
            sweepstakes.RegisterContestant(contestant1);
            Contestant contestant2 = new Contestant();
            contestant2.Email_Address = "archana@gmail.com";
            contestant2.First_Name = "archana";
            contestant2.Last_Name = "kar";
            sweepstakes.RegisterContestant(contestant2);

            string winner = sweepstakes.PickWinner();
            Console.WriteLine("1st " + winner);
            winner = sweepstakes.PickWinner();
            Console.WriteLine("2nd " + winner);
            winner = sweepstakes.PickWinner();
            Console.WriteLine("3rd " + winner);

            sweepstakes.PrintContestantInfo(contestant);
            sweepstakes.PrintContestantInfo(contestant1);
            sweepstakes.PrintContestantInfo(contestant2);

           // string user = User.PickSweepstakesTypeManager();//variable to store input of manager type
            sweepstakes.NotifyEachContestants();
            sweepstakes.NotifyWinnerEmail(contestant);

            Console.ReadLine();

            Contestant contestant3 = new Contestant();
            contestant3.First_Name = User.GetFirstName();
            Console.ReadLine();
            contestant3.Last_Name = User.GetLastName();
            Console.ReadLine();
            contestant3.Email_Address = User.GetEmail();
            Console.ReadLine();

            User.DisplayConstestantInfo(contestant3);

            string user = User.PickSweepstakesTypeManager(); //variable to store input of manager type
            Console.ReadLine();

        }
    }
}

