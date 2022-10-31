using System;
using System.Collections.Generic;
using System.Text;

namespace Calcul
{
    public class ConsoleServices : IConsoleServices
    {
        public void WriteLine(string toWrite)
        {
            Console.WriteLine(toWrite); 
        }
    }
}
