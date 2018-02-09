using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace programServer
{
    class OurServer
    {
        private static ManualResetEvent allDone = new ManualResetEvent(false);
        public static UdpClient udpClient_S;
        ForUI ourUI = new ForUI();
        private int port;

        public OurServer(int _port)
        {
            udpClient_S = new UdpClient(_port);
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
            String[] words = data.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nMessage from the client: {0}\n", data);
            //foreach(var word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //byte[] z = Encoding.Unicode.GetBytes("Your message is delivered \n");
            //udpClient_S.SendAsync(z, z.Length, ep);
           
            string fromSw = ourUI.Menu(words[0], words[1]);

            byte[] z2 = Encoding.Unicode.GetBytes(fromSw);
            udpClient_S.SendAsync(z2, z2.Length, ep);
        }
    }
}
