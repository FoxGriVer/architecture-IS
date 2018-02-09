using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_lab1
{
    class CarFactory
    {
        public List<Auto> listAuto = new List<Auto>();
        string[] masString = { "модель", "цвет", "номер", "цена","год", "владелец" };


        public CarFactory()
        {
                       
        }

        public void AddBaseAuto()
        {
            listAuto.Add(new Auto());
        }

        public void AddOurAuto()
        {
            try
            {
                Console.WriteLine("Создаем собственный автомобиль");
                Console.Write("Введите модель автомобиля: ");
                masString[0] = Console.ReadLine();
                Console.Write("Введите цвет автомобиля: ");
                masString[1] = Console.ReadLine();

                while (true) // проверка на число и кол-во символов
                {
                    Console.Write("Введите номер автомобиля: ");
                    string input = Console.ReadLine();
                    int x = 0;

                    if (Int32.TryParse(input, out x) && input.Length == 6)
                    {                        
                            masString[2] = input;
                            break;                                                
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите число состоящее из 6 цифр.");
                    }
                }               
                
                while (true) // проверка на число 
                {
                    Console.Write("Введите цену автомобиля ($$$): ");
                    string input = Console.ReadLine();
                    int x = 0;

                    if (Int32.TryParse(input, out x))
                    {                        
                            masString[3] = input;
                            break;                        
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите число.");
                    }
                }                
                
                while (true) // проверка на число и корректную дату
                {
                    Console.Write("Введите год автомобиля: ");
                    string input = Console.ReadLine();
                    int x = 0;                                  

                    if (Int32.TryParse(input, out x))
                    {
                        if (Convert.ToInt32(input) > 1980 && Convert.ToInt32(input) < 2017)
                        {
                            masString[4] = Convert.ToString(x);
                            break;
                        }
                        Console.WriteLine("Некорректный ввод. Введите реальный год");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите число");
                    }
                }

                Console.Write("Введите владельца автомобиля: ");
                masString[5] = Console.ReadLine();

                Auto specialAuto = new Auto(masString[0], masString[1], masString[2], masString[3], Int32.Parse(masString[4]), masString[5]);
                listAuto.Add(specialAuto);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        

        public void ShowConcreteAuto(int index)
        {
            for (int i = 0; i < listAuto.Count; i++)
            {
                if(index == i + 1)
                {
                    Console.Write(listAuto[i].Model + "," + listAuto[i].Color + "," + listAuto[i].SerialNumber + ",");
                    Console.WriteLine(listAuto[i].Price + "," + listAuto[i].Year + "," + listAuto[i].Owner);
                }
            }
        }

        public void DeleteAuto(int index)
        {
            for (int i = 0; i < listAuto.Count; i++)
            {
                if (index == i + 1)
                {
                    Console.Write(listAuto[i].Model + "," + listAuto[i].Color + "," + listAuto[i].SerialNumber + ",");
                    Console.WriteLine(listAuto[i].Price + "," + listAuto[i].Year + "," + listAuto[i].Owner);
                }
            }
            listAuto.RemoveAt(index - 1);
        }
    }
}
