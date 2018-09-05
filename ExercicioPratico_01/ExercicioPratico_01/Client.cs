using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_01
{
    class Client
    {
        const int MAX = 2;
        private int numContas = 0;
        private string nome;
        private long cpf;

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
            for(int i= 0; i < numContas; i++)
            {
                Console.WriteLine(accounts[i]);
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                Console.WriteLine("CPF inválido.");
                cpf = value >= 0 ? value : 0;
            }
        }
    }
}
