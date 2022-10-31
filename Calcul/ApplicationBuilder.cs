using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calcul
{

    public interface IApplicationBuilder
    {
        IApplicationBuilder Use(Action<IServiceCollection> action);
        ServiceProvider Build();
    }

    /// <summary>
    /// Class d'assistance abstract la creation d'une application .NET Core
    /// Cette class represente une chaine de traitement qui initie des composant utiles a l'application
    /// </summary>
    public class ApplicationBuilder : IApplicationBuilder
    {
        private readonly IList<Action<IServiceCollection>> _components = new List<Action<IServiceCollection>>();
        private readonly IServiceCollection _serviceCollection;

        public ApplicationBuilder(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        /// <summary>
        /// Methode appele par chacun des composants etendus afin d'ajouter la fonction du configuration du composant a la chaine de traitement
        /// </summary>
        /// <param name="action">foonction de configuation</param>
        /// <returns>Ce constructeur d'application</returns>
        public IApplicationBuilder Use(Action<IServiceCollection> action)
        {
            _components.Add(action);
            return this;
        }

        /// <summary>
        /// Parcours la chaine de traiement et execute chacun des composants ajoutes grace a la methode Use(Action)
        /// </summary>
        /// <returns>Un fournisseur de dependances</returns>
        public ServiceProvider Build()
        {
            foreach (var component in _components)
            {
                component(_serviceCollection);
            }

            return _serviceCollection.BuildServiceProvider();
        }
    }
}
