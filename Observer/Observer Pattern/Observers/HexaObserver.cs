using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class HexaObserver : Observer
    {

        public HexaObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: " + Convert.ToString(Subject.GetState(), 16));
        }
    }
}
