using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal_Finances.FinManager;

namespace Personal_Finances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transactions> transactions = new List<Transactions>();
            Test.test(transactions);
            Console.Write("Введите баланс: \n> ");
            balance = Convert.ToInt32(Console.ReadLine());

            // Основной цикл программы
            while (true)
            {
                Console.WriteLine("\n=== Меню ===");
                Console.WriteLine("1. Добавить транзакцию");
                Console.WriteLine("2. Удалить транзакцию");
                Console.WriteLine("3. Просмотреть все транзакции");
                Console.WriteLine("4. Посмотреть баланс");
                Console.WriteLine("5. Выйти");
                Console.WriteLine($"\n# Ваш текущий баланс: {balance}\n");

                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Добавление транзакции
                        Console.Write("Введите сумму: ");
                        int Summa = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите категорию: ");
                        string Category = Console.ReadLine();

                        Console.Write("Введите дату (формат: yyyy-MM-dd): ");
                        DateTime Date = DateTime.Parse(Console.ReadLine());

                        Transactions newTransaction = new Transactions { id = transactions[transactions.Count - 1].id + 1, 
                                                                         summa = Summa, 
                                                                         category = Category, 
                                                                         date = Date };
                        AddTrans(transactions, newTransaction);
                        Console.WriteLine("Транзакция добавлена.");
                        break;

                    case "2": // Удаление транзакции
                        Console.WriteLine("Список транзакций:");
                        PrintTrans(transactions);

                        Console.Write("Введите номер транзакции для удаления: ");
                        int id = Convert.ToInt32(Console.ReadLine()) - 1;

                        RemoveTrans(transactions, id);
                        Console.WriteLine("Транзакция удалена.");
                        break;

                    case "3": // Просмотр всех транзакций
                        Console.WriteLine("Список транзакций:");
                        PrintTrans(transactions);
                        break;

                    case "4":
                        Console.WriteLine(balance);
                        break;

                    case "5": // Выход из программы
                        Console.WriteLine("Программа завершена.");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }

        }
    }
}
