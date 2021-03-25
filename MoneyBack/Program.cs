using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ReturnCoins(200, 37));
            Console.ReadLine();
        }

        static readonly int[] coins = new int[] { 50, 20, 10, 5, 2, 1 };
        static int coinIndex = 0;

        public static string ReturnCoins(int given, int pay)
        {
            if (given <= pay)
            {
                if (given == pay)
                    return "Nic nevracet";
                else
                    return "Málo peněz";
            }

            return GetCoins(given - pay);
        }

        static string GetCoins(int rest)
        {
            if (rest == 0)
                return string.Empty;

            if (!(rest / coins[coinIndex] == 0))
            {
                coinIndex++;
                return rest / coins[coinIndex-1] + "x " + coins[coinIndex-1] + "Kc minci\n" + GetCoins(rest % coins[coinIndex-1]);
            }

            coinIndex++;
            return GetCoins(rest % coins[coinIndex - 1]);
        }
    }
}
