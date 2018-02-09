using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Net.Sockets;
using System.Net;

namespace AIS_Lab4
{
    class ViewModel
    {
        public ObservableCollection<Car> Cars { get; set; }
        static public UdpClient ourUdpClient;

        public string comingData;      

        public ViewModel()
        {
            Cars = new ObservableCollection<Car>();
            comingData = "Honda,Red,1996,Oleg,True@Mazda,Black,2010,Misha,True@Mersedes,White,2016,Savelii,False@";
        }

        public void DownloadData()
        {
            string InData = comingData;
            string[] FirstSplitMas;
            string[] SecondSplitMas;

            FirstSplitMas = InData.Split(new char[] { '@' });

            for (int i = 0; i < FirstSplitMas.Length - 1; i++)
            {
                SecondSplitMas = FirstSplitMas[i].Split(new char[] { ',' });
                Cars.Add(new Car { Model = SecondSplitMas[0], Color = SecondSplitMas[1], Year = SecondSplitMas[2], Owner = SecondSplitMas[3], Type =Convert.ToBoolean(SecondSplitMas[4]) });
            }
        }

        public void MakeConnection(string SendInf)
        {
            ourUdpClient = new UdpClient(8002);
            try
            {
                SendMessage(SendInf);
                ReceiveMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ourUdpClient.Close();
            }
        }

        public string SendData()
        {
            string resultString = "";
            foreach(Car carIn in Cars)
            {
                resultString += carIn.Model + "," + carIn.Color + "," + carIn.Year + "," + carIn.Owner + "," + Convert.ToString(carIn.Type) + "@";
            }
            return resultString;
        }

        public static void SendMessage(String mes)
        {
            try
            {
                string clientMessage = mes;
                byte[] data = Encoding.Unicode.GetBytes(clientMessage);
                ourUdpClient.Send(data, data.Length, "127.0.0.1", 8001);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReceiveMessage()
        {
            IPEndPoint ourRemoteIP = (IPEndPoint)ourUdpClient.Client.LocalEndPoint;
            try
            {
                byte[] data = ourUdpClient.Receive(ref ourRemoteIP);
                string message = Encoding.Unicode.GetString(data);
                comingData = message;                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
