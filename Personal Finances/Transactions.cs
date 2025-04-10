using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finances
{
    class Transactions
    {
        private int _id;
        private int _summa;
        private string _category;
        private DateTime _date;

        public int id
        {
            get => _id;
            set => _id = value >= 0 ? value : throw new ArgumentException("ID не может быть отрицательным.");
        }

        public int summa
        {
            get => _summa;
            set => _summa = value > 0 ? value : throw new ArgumentException("Сумма должна быть больше 0.");
        }

        public string category
        {
            get => _category;
            set => _category = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Категория не может быть пустой.") : value;
        }

        public DateTime date
        {
            get => _date;
            set => _date = value >= new DateTime(2000, 1, 1) ? value : throw new ArgumentException("Дата не может быть раньше 2000 года.");
        }
    }
}
