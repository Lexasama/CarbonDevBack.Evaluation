using System;
using Microsoft.Extensions.DependencyInjection;

namespace Calcul
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = InitializeApplication.InitApplication();
            var calculusServices = serviceProvider.GetService<ICalculusServices>();
            var consoleServices = serviceProvider.GetService<IConsoleServices>(); 

            var a = 10;
            var b = 5; 

            var additionResult = calculusServices.Add(a, b);
            consoleServices.WriteLine($" additionResult : {additionResult}"); 


        }
    }
}
