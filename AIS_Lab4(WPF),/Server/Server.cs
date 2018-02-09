using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace Server
{
    class Server
    {
        private static ManualResetEvent allDone = new ManualResetEvent(false);
        public static UdpClient udpClient_S;
        private Controller ourController;

        private int port;

        public Server(int _port)
        {
            udpClient_S = new UdpClient(_port);
            ourController = new Controller();
            this.port = _port;
            Console.WriteLine("Server is working");
        }

        public void startListenAsync()
        {
            while (true)
            {
                allDone.Reset();
                udpClient_S.BeginReceive(RequestCallback, udpClient_S);
                allDone.WaitOne();
            }
        }

        public static void SendMessage(string mes)
        {

            string message = mes;
            byte[] data = Encoding.Unicode.GetBytes(message);
            udpClient_S.Send(data, data.Length, "127.0.0.1", 8002);
        }

        private void RequestCallback(IAsyncResult ar)
        {
            allDone.Set();
            var listener = (UdpClient)ar.AsyncState;
            var ep = (IPEndPoint)udpClient_S.Client.LocalEndPoint;
            var res = listener.EndReceive(ar, ref ep);
            string data = Encoding.Unicode.GetString(res);
            Console.WriteLine("Сообщение от клиента: {0}",data);

            ourController.DecodMessage(data);

            //String[] words = data.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("\nMessage from the client: {0}\n", data);

            ////string fromSw = ourUI.Menu(words[0], words[1]);
            //string fromSwitch = ourView.ShowMenu(words[0], words[1]);

            byte[] z2 = Encoding.Unicode.GetBytes(data);
            udpClient_S.SendAsync(z2, z2.Length, ep);
        }

        
    }
}
