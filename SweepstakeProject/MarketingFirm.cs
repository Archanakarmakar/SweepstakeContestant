using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    public class MarketingFirm
    {
        int testNum = 0;
        string choice;

        public ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void MakeSweepstake()
        {
            testNum += 1;

            Sweepstakes newSweepstake = new Sweepstakes("TEST#" + testNum);
            manager.InsertSweepstakes(newSweepstake);
        }

        public void SetSweepstake(Sweepstakes newSweepstake)
        {
            Console.WriteLine("Welcome to the " + newSweepstake.name + " Sweepstakes!");
            for (int i = 0; i < newSweepstake.Max_Num; i++)
            {
              Contestant newContestant = new Contestant();
              Console.WriteLine("Contestant #" + (i + 1) + ", Please enter your name and email address.");
            }
              Console.WriteLine(newSweepstake.PickWinner() + " is the winner!");
        }
    }
}




