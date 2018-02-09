using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_lab1
{
    class UI
    {
        FileManager ourManager;
        CarFactory ourFactory;

        public UI()
            {
                ourManager = new FileManager();
                ourFactory = new CarFactory();
            }

        public void ShowMenu()
        {
            string key;
            do
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Выберите действие с файлом : \n1) Вывод всех записей на экран\n2) Вывод записи по номеру");
                    Console.WriteLine("3) Записать данные в файл\n4) Удалить запись из файла\n5) Добавление записи в файл\n6) Загрузить данные из файла");
                    Console.Write("\nНажмите кнопку... ");
                    key = Console.ReadLine();

                    switch (key)
                    {

                        case "6":
                            {
                                Console.WriteLine("\nЗаписи в файле:");
                                ourManager.ShowFile();
                                ourManager.ReadFileLines();
                                ourManager.AssembleFile();
                                ourManager.ReWriteFile(); // только для тестировки (преобразует в изначальный файл)
                                break;
                            }
                        case "2":
                            {

                                Console.Write("Введите номер записи которую хотите получить ... ");
                                int num = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n{0} запись в файле:", num);
                                ourManager.ourFactory.ShowConcreteAuto(num);
                                break;
                            }
                        case "3":
                            {
                                ourManager.ourFactory.AddOurAuto();
                                ourManager.ReWriteFileDuring();
                                break;
                            }
                        case "4":
                            {

                                Console.Write("Введите номер записи которую хотите удалить ... ");
                                int num = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n{0} запись в файле удалена:", num);
                                ourManager.ourFactory.DeleteAuto(num);
                                ourManager.ReWriteFileDuring(); // проблемы при удалении
                                break;
                            }
                        case "5":
                            {
                                ourManager.AddAuto();
                                break;
                            }
                        case "1":
                            {
                                ourManager.ShowFinalFile();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Вы ввели что-то другое");
                                break;
                            }
                    }
                    Console.Write("\nENTER - продолжить; ESC - выйти из программы");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
