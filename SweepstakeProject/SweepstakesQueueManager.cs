﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
      public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Sweepstakes Added in Queue...."); 
            sweepstakesQueue.Enqueue(sweepstakes); 
        }
        public Sweepstakes GetSweepstake()
        {
            Console.WriteLine("Sweepstakes Deleted in Queue....");
            return sweepstakesQueue.Dequeue();  
        }
    }
}
