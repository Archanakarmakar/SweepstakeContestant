using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    class Program
    {
        public static ISweepstakesManager manager;
        static void Main(string[] args)
        {

            string choice = User.ChooseManagerType();
            ISweepstakesManager manager = null;
            switch (choice)
            {
                case "Stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    break;
            }
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}

