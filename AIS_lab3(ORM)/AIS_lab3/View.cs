using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_lab3
{
    class View
    {
        Model ourModel;

        public View()
        {
            ourModel = new Model();
        }

        public string ShowMenu(string numberOfOperation, string addInf = "")
        {
            string allRecords = "";
            switch (numberOfOperation)
            {
                case "1":
                    {
                        Console.WriteLine("\nЗаписи в файле:");
                        allRecords = ourModel.ShowAllCars();                        
                        return allRecords = ourModel.ourText;
                    }
                case "2":
                    {
                        int num = Convert.ToInt32(addInf);
                        Console.WriteLine("\n{0} запись в файле:", num);
                        return allRecords = ourModel.ShowConcCar(num);
                    }
                case "3":
                    {
                        String[] words = addInf.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        allRecords = ourModel.AddOurAuto(words[0], words[1], words[2], Convert.ToInt32(words[3]),words[4] );
                        //allRecords = ourManager.ourFactory.AddOurAuto(words[0], words[1], words[2], words[3], Convert.ToInt32(words[4]), words[5]);
                        //ourManager.ReWriteFileDuring();
                        return allRecords;
                    }
                case "4":
                    {
                        int num = int.Parse(addInf);
                        Console.WriteLine("\n{0} запись в файле удалена:", num);
                        ourModel.DeleteConcCar(num);                        
                        return allRecords = "Автомобиль удален";
                    }
                case "5":
                    {
                        ourModel.AddBaseCar();
                        return allRecords = "Базовый автомобиль добавлен";
                    }
                default:
                    {
                        return allRecords = " ";
                    }
            }


            //    string key;
            //    do
            //    {
            //        try
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Выберите действие : \n1) Вывести все записи на экран\n2) Вывести запись по номеру");
            //            Console.WriteLine("3) Добавить запись\n4) Удалить запись \n5) Добавить базовую запись\n");
            //            Console.Write("\nНажмите кнопку... ");
            //            key = Console.ReadLine();
            //            switch(key)
            //            {
            //                case "1":
            //                    {
            //                        ourModel.ShowAllCars();
            //                        break;
            //                    }
            //                case "2":
            //                    {
            //                        Console.Write("Введите номер записи которую хотите получить ... ");
            //                        int num = int.Parse(Console.ReadLine());
            //                        Console.WriteLine("\n{0} запись в файле:", num);
            //                        ourModel.ShowConcCar(num);
            //                        break;
            //                    }
            //                case "3":
            //                    {
            //                        ourModel.AddConcCar();
            //                        break;
            //                    }
            //                case "4":
            //                    {
            //                        Console.Write("Введите номер записи которую хотите удалить ... ");
            //                        int num = int.Parse(Console.ReadLine());
            //                        Console.WriteLine("\n{0} запись в файле удалена", num);
            //                        ourModel.DeleteConcCar(num);
            //                        break;
            //                    }
            //                case "5":
            //                    {
            //                        ourModel.AddBaseCar();
            //                        break;
            //                    }
            //                default:
            //                    {
            //                        Console.WriteLine("Вы ввели что-то другое");
            //                        break;
            //                    }

            //            }
            //            Console.Write("\nENTER - продолжить; ESC - выйти из программы");

            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }

            //    } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
