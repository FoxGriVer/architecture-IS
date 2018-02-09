using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace programServer
{
    class ForUI
    {
        FileManager ourManager;
        CarFactory ourFactory;

        public ForUI()
        {
            ourManager = new FileManager();
            ourFactory = new CarFactory();            
        }

        public string Menu(string numberOfOperation, string addInf = "")
        {
            string allRecords = "";
            switch(numberOfOperation)
            {
                case "1":
                    {
                        Console.WriteLine("\nЗаписи в файле:");
                        ourManager.ShowFinalFile();
                        return allRecords = ourManager.ourText;
                    }
                case "2":
                    {                        
                        int num = Convert.ToInt32(addInf);
                        Console.WriteLine("\n{0} запись в файле:",num);
                        return allRecords = ourManager.ourFactory.ShowConcreteAuto(num);                        
                    }
                case "3":
                    {
                        String[] words = addInf.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        allRecords =  ourManager.ourFactory.AddOurAuto(words[0], words[1], words[2], words[3],Convert.ToInt32(words[4]), words[5]);
                        ourManager.ReWriteFileDuring();
                        return allRecords;
                    }
                case "4":
                    {
                        
                        int num = int.Parse(addInf);
                        Console.WriteLine("\n{0} запись в файле удалена:", num);
                        ourManager.ourFactory.DeleteAuto(num);
                        ourManager.ReWriteFileDuring();
                        return allRecords = "Автомобиль удален";
                    }
                case "5":
                    {
                        ourManager.AddAuto();
                        return allRecords = "Базовый автомобиль добавлен";
                    }
                case "6":
                    {
                        Console.WriteLine("\nЗаписи в файле:");
                        ourManager.ShowFile();
                        ourManager.ReadFileLines();
                        ourManager.AssembleFile();
                        ourManager.ReWriteFile(); // только для тестировки (преобразует в изначальный файл)
                        return allRecords = ourManager.ourText;                                               
                    }
                default:
                    {
                        return allRecords = " ";
                    }
            }
        }
    }
}
