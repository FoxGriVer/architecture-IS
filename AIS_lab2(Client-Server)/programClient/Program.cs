using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace programClient
{
    class Program
    {        
        static void Main(string[] args)
        {
            Menu ourMenu = new Menu();
            ourMenu.ShowMenu();
        }
    }
}

//private static void ShowMenu()
//{
//    string forSwitch;

//    do
//    {
//        try
//        {
//            Console.Clear();

//            Console.WriteLine("Выберите действие с файлом : \n1) Вывод всех записей на экран\n2) Вывод записи по номеру");
//            Console.WriteLine("3) Записать данные в файл\n4) Удалить запись из файла\n5) Добавление записи в файл\n6) Загрузить данные из файла");
//            Console.Write("\nНажмите кнопку... ");

//            forSwitch = Console.ReadLine();
//            SendMessage(forSwitch);
//            ReceiveMessage();

//            Console.Write("\nENTER - продолжить; ESC - выйти из программы");
//        }
//        catch (FormatException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    } while (Console.ReadKey().Key != ConsoleKey.Escape);
//    //ReceiveMessage();
//}


