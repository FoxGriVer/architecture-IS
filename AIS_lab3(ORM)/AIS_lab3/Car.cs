using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_lab3
{
    class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string SerialNumber { get; set; }
        public int Year { get; set; }
        public string Owner { get; set; }       
        //public Car(string model = "x", string color = "x", string serialNumber = "x", int year = 0, string owner = "x")
        //{
        //    Model = model;
        //    Color = color;
        //    SerialNumber = serialNumber;
        //    Year = year;
        //    Owner = owner;
        //}
    }
}
