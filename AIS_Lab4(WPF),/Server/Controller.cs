using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Controller
    {
        public void DecodMessage(string dMes)
        {
            string InData = dMes;
            string[] FirstSplitMas;
            string[] SecondSplitMas;

            FirstSplitMas = InData.Split(new char[] { '@' });
            using (CarContext db = new CarContext())
            {
                db.Database.ExecuteSqlCommand("Delete from Cars");

                for (int i = 0; i < FirstSplitMas.Length - 1; i++)
                {
                    SecondSplitMas = FirstSplitMas[i].Split(new char[] { ',' });

                    db.Cars.Add(new Car { Model = SecondSplitMas[0], Color = SecondSplitMas[1], Year = SecondSplitMas[2], Owner = SecondSplitMas[3], Type = Convert.ToBoolean(SecondSplitMas[4]) });
                    db.SaveChanges();

                }
            }
        }
    }
}
