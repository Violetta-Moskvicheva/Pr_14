using Pr_14.Models;

namespace Pr_14
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                // создаем два объекта User
                User tom = new User { Name = "Том", Age = 33 };
                User alice = new User { Name = "Алиса", Age = 26 };

                // добавляем их в бд
                db.Users.Add(tom);
                db.Users.Add(alice);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены в PostgreSQL");

                // получаем объекты из бд и выводим на консоль
                var usersList = db.Users.ToList();
                Console.WriteLine("Список пользователей из БД:");
                foreach (User u in usersList)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            Console.ReadKey(); // Чтобы консоль не закрылась сразу

            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}