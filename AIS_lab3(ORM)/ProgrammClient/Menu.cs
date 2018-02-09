using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ProgrammClient
{
    class Menu
    {
        static public UdpClient ourUdpClient;

        public void ShowMenu()
        {
            string forSwitch;
            ourUdpClient = new UdpClient(8002);
            Console.WriteLine("Client is working");

            try
            {

                do
                {
                    try
                    {
                        Console.Clear();

                        Console.WriteLine("Выберите действие : \n1) Вывести все записи на экран\n2) Вывести запись по номеру");
                        Console.WriteLine("3) Добавить запись\n4) Удалить запись \n5) Добавить базовую запись\n");
                        Console.Write("\nНажмите кнопку... ");

                        forSwitch = Console.ReadLine();
                        string fullMessage = "";

                        switch (forSwitch)
                        {
                            case "1":
                                {
                                    fullMessage = forSwitch + ';' + "1";
                                    SendMessage(fullMessage);
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Введите номер записи которую хотите получить ... ");
                                    int num = int.Parse(Console.ReadLine());
                                    fullMessage = forSwitch + ';' + Convert.ToString(num);
                                    SendMessage(fullMessage);
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Введите данные о автомобиле в формате : -модель,цвет,номер,год,владелец- ... ");
                                    string aboutAuto = Console.ReadLine();
                                    fullMessage = forSwitch + ';' + aboutAuto;
                                    SendMessage(fullMessage);
                                    break;
                                }
                            case "4":
                                {
                                    Console.Write("Введите номер записи которую хотите удалить ... ");
                                    int num = int.Parse(Console.ReadLine());
                                    fullMessage = forSwitch + ';' + Convert.ToString(num);
                                    SendMessage(fullMessage);
                                    break;
                                }
                            case "5":
                                {
                                    fullMessage = forSwitch + ';' + "5";
                                    SendMessage(fullMessage);
                                    break;
                                }                            
                            default:
                                {
                                    break;
                                }

                        }

                        ReceiveMessage();
                        Console.Write("\nENTER - продолжить; ESC - выйти из программы");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
                Console.ReadKey();
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

        private static void SendMessage(String mes, string addInf = "")
        {
            try
            {
                //Console.WriteLine("Your message is : {0}",mes);
                string clientMessage = mes;
                byte[] data = Encoding.Unicode.GetBytes(clientMessage);
                ourUdpClient.Send(data, data.Length, "127.0.0.1", 8001);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ReceiveMessage()
        {
            IPEndPoint ourRemoteIP = (IPEndPoint)ourUdpClient.Client.LocalEndPoint;
            try
            {
                byte[] data = ourUdpClient.Receive(ref ourRemoteIP);
                string message = Encoding.Unicode.GetString(data);
                Console.WriteLine("Answer form the server: \n{0}", message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
