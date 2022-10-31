using System;
using System.Collections.Generic;

namespace Refacto
{
    public static class PriceService
    {

        private static Dictionary<int, Func<decimal, decimal, decimal>> Formulas = new Dictionary<int, Func<decimal, decimal, decimal>>()
        {
            {1, (amount, disc) => TypeOne(amount, disc)},
            {2, (amount, disc) => TypeTwo(amount, disc) },
            {3, (amount, disc) => TypeThree(amount, disc) },
            {4, (amount, disc) => TypeFour(amount, disc) }
        };
        public static decimal CalculateDiscount(decimal amount, int type, int years)
        {
            // Refactorize this function
            decimal result = 0;
            decimal disc;

            disc = (years > 5) ? 5 / 100 : years / 100;

            return Formulas[type].Invoke(amount, disc);
        }

        private static decimal TypeThree(decimal amount, decimal disc)
        {
            return (0.7m * amount) - disc * (0.7m * amount);
        }

        private static decimal TypeOne(decimal amount, decimal disc)
        {
            return amount;
        }

        private static decimal TypeFour(decimal amount, decimal disc)
        {
            return (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
        }

        private static decimal TypeTwo(decimal amount, decimal disc)
        {
            return (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
        }
    }
}
