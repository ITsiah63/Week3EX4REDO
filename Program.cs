using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Week3Ex4REDO
{
    internal class Program
    {       
        
        static void Main(string[] args)
        {
            //declaring variables used in this function
            int user;           
            double balance = 1000;
            int deposit;
            int withdrawl;

            //looping process as long as user is at ATM 
            while (true) {
                //listing menu options
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawl");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option: ");
                user = Convert.ToInt32(Console.ReadLine()); //what the user chooses

                //processing user request
                if (user == 1)
                {
                    Console.WriteLine("Your balance is " + balance);//printing out balance
                }
                else if (user == 2)//processing a deposit by the user
                {
                    Console.WriteLine("Enter deposit amount:");
                    deposit = Convert.ToInt32(Console.ReadLine());
                    balance = deposit + balance;
                    Console.WriteLine("Deposit successful");
                }
                else if (user == 3)//processing a withdrawl by the user
                {
                    Console.WriteLine("Enter withdrawl amount:");
                    withdrawl = Convert.ToInt32(Console.ReadLine());
                    balance = balance - withdrawl;
                    Console.WriteLine("Please take your cash");
                }
                else if (user == 4)//breaking the while loop 
                {
                    Console.WriteLine("See you Next time");
                    break;
                }
               
                
            }

        }
    }
}
