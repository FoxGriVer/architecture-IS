using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AIS_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CarContext db = new CarContext())
            {                

                Server server = new Server(8001);
                server.startListenAsync();

            }
        }
    }
}
