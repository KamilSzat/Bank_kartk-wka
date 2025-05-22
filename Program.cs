using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            var konto = new Bank(123, 200);


            Console.WriteLine($"Stan konta wynosi: {konto.getStanKonta()}");
            Console.WriteLine("Podaj kwotę do wpłaty: ");

            if (double.TryParse(Console.ReadLine(), out double kwotaWpłaty))
            {
                if (konto.wplata(kwotaWpłaty))
                {
                Console.WriteLine($"Nowy stan konta: {konto.getStanKonta()}");
                }
            }

            Console.WriteLine("Podaj kwotę do wypłaty: ");
            if (double.TryParse(Console.ReadLine(), out double kwotaWypłaty))
            {
                if (konto.wyplata(kwotaWypłaty))
                {
                    Console.WriteLine($"Nowy stan konta: {konto.getStanKonta()}");
                }
                else
                {
                    Console.WriteLine("Nie prawidłowa kwota wypłaty/ujemne środki na koncie.");
                }
            }
            
        }
    }
}
