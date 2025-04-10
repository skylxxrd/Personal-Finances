using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Personal_Finances
{
    static class FinManager
    {
        public static int balance = 0;
        // Add transaction
        static public void AddTrans(List<Transactions> transactions, Transactions trans)
        {
            transactions.Add(trans);
            balance -= trans.summa;
        }

        // Remove Trans
        static public void RemoveTrans(List<Transactions> transactions, int id)
        {
            if (id >= 0 && id < transactions.Count)
            {
                balance += transactions[id].summa;
                transactions.RemoveAt(id);
            }
        }

        // Print Trans
        static public void PrintTrans(List<Transactions> transactions)
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("Транзакций нет.");
            }
            else
            {
                foreach (Transactions t in transactions)
                {
                    Console.WriteLine($"id: {t.id}, sum: {t.summa}, category: {t.category}, date: {t.date}");
                }
            }
        }

    }
}
