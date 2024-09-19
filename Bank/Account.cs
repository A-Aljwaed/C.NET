using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {

        public int AccNo { get;  }
        public String Owner  { get;  }
        public Double Balance { get; private set; }



        public Account(int accNo,String owner,Double balance) { 

            AccNo = accNo;
             Owner = owner;
            Balance = balance;
        
        }

        public Account()
        {
        }

        public void makeDeposit(int amounth)
        {
            this.Balance+= amounth;
        }

        public void makeWithdeow(int amount)
        {
            if (this.Balance == amount || Balance > amount) { this.Balance -= amount; }
            else { Console.WriteLine(" nicht genug Geld da"); }
        }



        public void getBalance() {
            Console.WriteLine($" Kontostand von {Owner}: {Balance}");
        }
    }
}
