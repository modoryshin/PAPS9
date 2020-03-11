using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем новый аккаунт
            Account acc = new Account();
            //Создаем новый банк
            Bank bank = new Bank("Сбербанк",acc);
            //Генерируем данные для счета и отправляем уведомление
            acc.GenerateData();
            //Удаляем аккаунт
            bank.BlockAccount();
            Console.ReadKey();
        }
    }
}
