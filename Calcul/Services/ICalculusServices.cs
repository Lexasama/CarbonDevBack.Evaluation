using System;
using System.Collections.Generic;
using System.Text;

namespace Calcul
{
    public interface ICalculusServices
    {
        /// <summary>
        /// Retourne la somme de a et b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Add(int a, int b);
        /// <summary>
        /// Retourne la différnce entre a et b 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Diff(int a, int b);
        /// <summary>
        /// Calcul le factoriel de a
        /// n! = (n-1)!*n avec 1!=1 et 0!=1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        long Factorial(int a);

        /// <summary>
        /// retourne le rapport de a/b. si b est b=0 la fonction lève une exception
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Fraction(double a, double b); 

    }
}
