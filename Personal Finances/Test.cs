using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finances
{
    static class Test
    {
        static public List<Transactions> test(List<Transactions> transactions)
        {
            DateTime baseDate = new DateTime(2000, 1, 1, 0, 0, 0);
            for (int i = 1; i <= 50; i += 2)
            {
                int Id = transactions.Count > 0 ? transactions[transactions.Count - 1].id + 1 : 1;
                int Summa = i * 100;
                string Category = $"Category_{i % 5}";
                DateTime Date = baseDate.AddDays(i);

                Transactions transaction = new Transactions {id = Id, summa = Summa, category = Category, date = Date };
                transactions.Add(transaction);
            }
            return transactions;
        }
    }
}
