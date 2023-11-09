using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упр. 9.1
            BankAccount client1 = new BankAccount(balance: 30012);
            Console.WriteLine(client1.Balance_Account);
            Console.WriteLine(client1.Number_Account);
            BankAccount client2 = new BankAccount(BankAccount.Type_bank_account.Текущий);
            Console.WriteLine(client2.Type_Bank_Account);
            Console.WriteLine(client2.Number_Account);
            BankAccount client3 = new BankAccount(balance: 1343546, BankAccount.Type_bank_account.Сберегательный);
            Console.WriteLine(client3.Type_Bank_Account);
            Console.WriteLine(client3.Balance_Account);
            Console.WriteLine(client3.Number_Account);

            //Упр. 9.2
            BankAccount2 client4 = new BankAccount2(balance: 23456, BankAccount2.Type_bank_account.Текущий);
            client4.Put_Money(1234567);
            Queue<BankTransaction> transactions = client4.Transactions;
            BankTransaction transaction = transactions.Dequeue();
            Console.WriteLine(transaction.DateTime_Transaction);

            //Упр. 9.3
            BankAccount2 client5 = new BankAccount2(balance: 34356, BankAccount2.Type_bank_account.Сберегательный);
            client5.Put_Money(32456);
            client5.Withdraw(3243);
            client5.Dispose(client5);
        }
    }
}
