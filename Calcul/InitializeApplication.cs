using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calcul
{
    public static class InitializeApplication
    {
        public static IServiceProvider InitApplication()
        {
            var serviceCollection = new ServiceCollection();
            IApplicationBuilder app = new ApplicationBuilder(serviceCollection);
            serviceCollection.AddTransient<IConsoleServices, ConsoleServices>(); 
            serviceCollection.AddTransient<ICalculusServices, CalculusServices>();
            return app.Build(); 

        }
    }
}
