using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    public class Sweepstakes
    {
        public string name;
        public int Max_Num;
        public int WinningGame;
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
       // public Dictionary
        Sweepstakes()
        {
        }
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.Registration_Num,contestant);
           // contestants.Add(contestant.First_Name, contestant);
        }  
        public string PickWinner()
        {
            Random r = new Random();
            WinningGame = r.Next(1, Max_Num + 1);
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == WinningGame)
                {
                    return contestant.Value.First_Name;
                }
            }
            return null;
        }


        //return;
    
        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant name: " + contestant.First_Name + " " + contestant.Last_Name);
            Console.WriteLine("Contestant Email: " + contestant.Email_Address);
            Console.WriteLine("Contestant #: " + contestant.Registration_Num);

        }


    }
}
