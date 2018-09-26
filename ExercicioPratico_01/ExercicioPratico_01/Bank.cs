using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_01
{
    class Bank
    {
        const int MAX = 2;
        private int numContas = 0;

        private int number;
        private Account[] accounts = new Account[MAX];

        public void AddAccount(Account a)
        {
            if (numContas < MAX)
                accounts[numContas++] = a;
            else
                Console.WriteLine("Não foi possível adicionar uma nova conta.");
        }

        public void RemoveAccount(Account a)
        {
            int idx = -1;

            for (int i = 0; i < numContas; i++)
                if (accounts[i] == a)
                    idx = i;

            if (idx >= 0)
            {
                for (int i = idx; i < numContas - 1; i++)
                    accounts[i] = accounts[i + 1];

                accounts[numContas - 1] = null;
                numContas--;
            }
        }

        public void ListAccounts()
        {
            ListAccounts(-1);
        }

        public void ListAccounts(int ag)
        {
            if(ag >= 0)
                for (int i = 0; i < numContas; i++)
                {
                    if (accounts[i].Agency == ag)
                        Console.WriteLine(accounts[i]);
                }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value >= 0 ? value : 0;
            }
        }

        public double ApproveLimit(double amount, int accountTime)
        {
            //Console.WriteLine(amount);
            return Math.Min(200 + accountTime * 300, amount);
        }
    }
}
