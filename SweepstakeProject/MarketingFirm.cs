using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakeProject
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;
        
        //constructor dependency injection
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        
    }
}




