using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client();
            
            Bank b1 = new Bank();
            Bank b2 = new Bank();
            Bank b3 = new Bank();

            Account ac1 = new Account(c1, b1, 123);
            ac1.Number = 1; ac1.Agency = 11;

            Account ac2 = new Account(c1, b2, 123);
            ac2.Number = 2; ac2.Agency = 22;

            Account ac3 = new Account(c1, b3, 123);
            ac3.Number = 3; ac3.Agency = 33;

            c1.AddAccount(ac1);
            c1.AddAccount(ac2);
            c1.AddAccount(ac3);

            c1.ListAccounts();

            c1.RemoveAccount(ac2);
            c1.AddAccount(ac3);

            c1.ListAccounts();

            ac1.IncreaseLimit(1000, 123);
            Console.WriteLine(ac1.AvailableCredit);

            ac1.AccountTime = 2;
            ac1.IncreaseLimit(1000, 123);
            Console.WriteLine(ac1.AvailableCredit);

            Console.Read();
        }
    }
}
