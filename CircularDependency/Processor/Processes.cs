using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMath;
using IProcessor;

namespace Processor
{
    public class Processes : IProcesses
    {
        public Processes(IMathOps math)
        {
            myMath = math;
        }

        IMathOps myMath;
        public void ReadFile()
        {
            myMath.Sum(1, 2);
            //Do something
        }

        public void SaveToFile()
        {
            //Do something
        }

        public void Print()
        {
            //Do something
        }
    }
}
