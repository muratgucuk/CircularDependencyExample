using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IProcessor;
using Processor;

namespace CircularDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            IMath.IMathOps math = new Math();
            IProcesses p = new Processes(math);
            p.ReadFile();
        }
    }
}
