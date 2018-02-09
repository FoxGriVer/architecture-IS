using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_lab3
{
    class Model
    {
        Car testCar = new Car();
        public string ourText = "";

        public string ShowAllCars()
        {
            using (CarContext db = new CarContext())
            {
                var cars = db.Cars;
                ourText = "";
                foreach (Car u in cars)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", u.CarId, u.Model, u.Color, u.SerialNumber, u.Year, u.Owner);
                    ourText += " " + u.CarId + ','+ u.Model + ',' + u.Color + ',' + u.SerialNumber + ',' + u.Year + ',' + u.Owner + "\n";
                }
                return ourText;
            }
        }

        public string ShowConcCar(int index)
        {
            using (CarContext db = new CarContext())
            {
                var carDel = db.Cars.Find(index);
                if (carDel != null)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", carDel.CarId, carDel.Model, carDel.Color, carDel.SerialNumber, carDel.Year, carDel.Owner);
                    ourText = " " + carDel.CarId + ',' + carDel.Model + ',' + carDel.Color + ',' + carDel.SerialNumber + ',' + carDel.Year + ',' + carDel.Owner;
                }
                return ourText;
            }
        }
        public string AddOurAuto(string model = "baseModel", string color = "baseColor", string serialNumber = "baseNumber",
           int year = 0, string owner = "none")
        {
            string[] masString = { "idVBD ","модель", "цвет", "номер", "год", "владелец" };

            try
            {
                Console.WriteLine("Создаем собственный автомобиль");
                masString[1] = model;
                masString[2] = color;

                int x = 0;
                string error = "";

                if (Int32.TryParse(serialNumber, out x) && serialNumber.Length == 6)
                {
                    masString[3] = serialNumber;

                }
                else
                {
                    error += "Некорректный ввод. Введите номер, состоящий из 6 цифр.\n";
                    //log.Error("Некорректный ввод. Введите число состоящее из 6 цифр.");
                }
               
                x = 0;
                if (Convert.ToInt32(year) > 1980 && Convert.ToInt32(year) < 2017)
                {
                    masString[4] = Convert.ToString(year);
                }
                else
                {
                    error += "Некорректный ввод. Введите реальный год\n";
                }

                masString[5] = owner;
                if (error == "")
                {
                    using (CarContext db = new CarContext())
                    {
                        Car newBaseCar = new Car { Model = masString[1], Color = masString[2], SerialNumber = masString[3], Year = Convert.ToInt32(masString[4]), Owner = masString[5] };
                        db.Cars.Add(newBaseCar);
                        db.SaveChanges();
                        Console.WriteLine("Автомобиль успешно создан !");
                        return "Автомобиль успешно создан !";
                    }
                }
                
                else
                {
                    return error;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }

        public void AddConcCar()
        {
            string[] masString = { "модель", "цвет", "номер", "год", "владелец" };

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

            while (true) // проверка на число и корректную дату
            {
                Console.Write("Введите год автомобиля: ");
                string input = Console.ReadLine();
                int x = 0;

                if (Int32.TryParse(input, out x))
                {
                    if (Convert.ToInt32(input) > 1980 && Convert.ToInt32(input) < 2017)
                    {
                        masString[3] = Convert.ToString(x);
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
            masString[4] = Console.ReadLine();

            using (CarContext db = new CarContext())
            {

                Car newBaseCar = new Car { Model = masString[0], Color = masString[1], SerialNumber = masString[2], Year =Convert.ToInt32(masString[3]), Owner = masString[4] };
                db.Cars.Add(newBaseCar);
                db.SaveChanges();
                Console.WriteLine("Автомобиль успешно создан !");
            }
        }

        public void AddBaseCar(string model = "x", string color = "x", string serialNumber = "x", int year = 0, string owner = "x")
        {
            using (CarContext db = new CarContext())
            {
                Car newBaseCar = new Car {Model = model, Color = color, SerialNumber = serialNumber, Year = year, Owner = owner };                
                db.Cars.Add(newBaseCar);
                db.SaveChanges();
                Console.WriteLine("Базовый автомобиль успешно создан !");
            }
        }

        public void DeleteConcCar(int index)
        {
            using (CarContext db = new CarContext())
            {
                var carDel = db.Cars.Find(index);
                if(carDel != null)
                {
                    db.Cars.Remove(carDel);
                    db.SaveChanges();
                }
            }                                
        }

        public void DeleteAllCars()
        {
            using(CarContext db = new CarContext())
            {
                var car_del = db.Cars.Where(p => p.CarId >= 0);
                if (car_del != null)
                {
                    db.Cars.RemoveRange(car_del);                                                               
                }
                db.SaveChanges();
            }
        }
    }
}
