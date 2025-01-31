using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{

    interface IAccount
    {
        void DepoMoney(ref int balance);


        void WithdrowMoney(ref int balance);
       

    }
    class Transaction : IAccount
    {
        public void DepoMoney(ref int balance)
        {
            Console.WriteLine("How much money you want to deposit:");
            int depo_money = int.Parse(Console.ReadLine());
            balance = balance + depo_money;
            Console.WriteLine("Total balance is: "+ balance);
            
        }

        public void WithdrowMoney(ref int balance)
        {
            Console.WriteLine("Enter amount you want to withdrow");
            int withdrow = int.Parse(Console.ReadLine());
            balance = balance - withdrow;
            Console.WriteLine("Updated balance: " + balance);
        }
    }

    public class BankingSystem 
    {

        public static void Account()
        {
            //Create an object-oriented model for a banking system that supports various account 
            //Implement transactional operations like
            //deposits, withdrawals

            Console.WriteLine("Enter the bank balance:");
            int balance = int.Parse(Console.ReadLine());

            Console.WriteLine("For Deposit enter 1 \nFor Withdrow enter 2: ");
            int operation = int.Parse(Console.ReadLine());

            Transaction transaction = new Transaction();
            if (operation == 1)
            {
                transaction.DepoMoney(ref balance);
            }
            else if (operation == 2)
            {
                 transaction.WithdrowMoney(ref balance);
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }



              

        }
        
    }
}
