using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            myServiceRef.Service1Client myWcfProxy = new myServiceRef.Service1Client();
            int degreeC = 20;
            int degreeF = 70;
            int CtoF = myWcfProxy.c2f(degreeC);
            int FtoC = myWcfProxy.f2c(degreeF);
            Console.WriteLine("{0} degree C equals {1} degree F", degreeC, CtoF);
            Console.WriteLine("{0} degree F equals {1} degree C", degreeF, FtoC);

            myWcfProxy.Close();
            Console.WriteLine("Press <ENTER> to terminate the client.");
            Console.ReadLine();
        }
    }
}
