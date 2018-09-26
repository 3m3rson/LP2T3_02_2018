using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_01
{
    class Account
    {
        private long number, agency;
        private double balance, availableCredit = 200;
        private int password, accountTime;
        private Client client;
        private Bank bank;

        public Account(Client c, Bank b, int password)
        {
            client = c;
            bank = b;
            this.password = password;
        }

        public bool Withdraw(double amount, int pwd)
        {
            if(password == pwd && amount <= balance + AvailableCredit && amount >=0)
            {
                balance -= amount;
                return true; 
            }
            return false;              
        }

        public bool Deposit(double amount, int pwd)
        {
            if (password == pwd && amount >= 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public Double Balance(int pwd)
        {
            if (password == pwd)
                return balance;
            else
                return 0; 
        }

        public double IncreaseLimit(double amount, int pwd)
        {
            if (password == pwd && amount >= 0)
            {
                availableCredit = bank.ApproveLimit(amount, accountTime);
                return availableCredit;
            }
                
            else
            {
                return 0;
            }
                
        }

        public override string ToString()
        {
            return "CC: " + number + " AG: " + agency ;
        }
        public long Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value >= 0? value : 0;
            }
        }

        public long Agency
        {
            get
            {
                return agency;
            }

            set
            {
                agency = value >= 0 ? value : 0;
            }
        }

        public int AccountTime
        {
            get
            {
                return accountTime;
            }

            set
            {
                accountTime = value >= 0 ? value : 0;
            }
        }

        public double AvailableCredit
        {
            get
            {
                return availableCredit;
            }

        }
    }
}
