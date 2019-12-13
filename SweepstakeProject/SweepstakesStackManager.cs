using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Sweepstakes push in Stack....");
            sweepstakesStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Sweepstakes pop in Stack....");
            return sweepstakesStack.Pop();
        }
    
    }
}
