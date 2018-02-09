using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Server
{
    class Program
    {

        static void Main(string[] args)
        {
            Server server = new Server(8001);

            using (CarContext db = new CarContext())
            {
                //db.Database.ExecuteSqlCommand("Delete from Cars");
                        
                var cars = db.Cars;
                Console.WriteLine("Список объектов:");
                foreach (Car c in cars)
                {
                    Console.WriteLine("{0},{1},{2},{3},{4}", c.Model, c.Color, c.Year, c.Owner, c.Type);
                }
            }

            server.startListenAsync();

            
        }
    }
}
