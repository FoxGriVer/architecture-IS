using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_lab1
{
    class Auto
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string SerialNumber { get; set; }
        public string Price { get; set; }
        public int Year { get; set; }
        public string Owner { get; set; }

        public Auto(string model = "baseModel", string color = "baseColor", string serialNumber = "baseNumber",
            string price = "0$", int year = 0, string owner = "none")
        {
            Model = model;
            Color = color;
            SerialNumber = serialNumber;
            Price = price;
            Year = year;
            Owner = owner;
        }

        //public void ChangeAutoData()
        //{

        //}

        //public void MakeAuto()
        //{

        //}

    }
}
