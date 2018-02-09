using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programServer
{
    class FileManager
    {
        public string ReadFilePath { get; private set; }
        public string WriteFilePath { get; set; }
        public string ourText = "";
        public string[,] arrayAutoData;
        public string[] arrayOnlyOneLine;

        public CarFactory ourFactory = new CarFactory();

        public FileManager(string rPth = @"C:\Users\Pavel\Desktop\ReadText2.txt",
            string wPth = @"C:\Users\Pavel\Desktop\WriteText2.txt")
        {
            ReadFilePath = rPth;
            WriteFilePath = wPth;
        }

        public void ShowFile()
        {
            StreamReader readFileObj = new StreamReader(ReadFilePath);
            ourText = readFileObj.ReadToEnd();
            Console.Write(ourText);
            readFileObj.Close();
        }

        public void ShowFinalFile()
        {
            StreamReader readFileObj = new StreamReader(WriteFilePath);
            ourText = readFileObj.ReadToEnd();
            Console.Write(ourText);
            readFileObj.Close();
        }

        public void ReadFileLines()  // считывает с исходного файла
        {
            StreamReader readFileObj = new StreamReader(ReadFilePath);
            arrayAutoData = new string[9, 6];
            arrayOnlyOneLine = new string[5];
            string line;
            int k = 0;
            while ((line = readFileObj.ReadLine()) != null)
            {
                arrayOnlyOneLine = line.Split(',');

                for (int i = 0; i <= 5; i++)
                {
                    arrayAutoData[k, i] = arrayOnlyOneLine[i];
                }
                k++;
            }
            readFileObj.Close();
        }

        public void ReWriteFile() // перезаписывает финал (очищает все его поля и приводит к первонач)
        {
            using (StreamWriter sw = new StreamWriter(WriteFilePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i <= arrayAutoData.Rank - 1; i++)
                {
                    sw.WriteLine(arrayAutoData[i, 0] + ',' + arrayAutoData[i, 1] + ',' + arrayAutoData[i, 2] + ',' +
                     arrayAutoData[i, 3] + ',' + arrayAutoData[i, 4] + ',' + arrayAutoData[i, 5]);
                }
            }
        }

        public void ReWriteFileDuring()
        {
            using (StreamWriter sw = new StreamWriter(WriteFilePath, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < ourFactory.listAuto.Count; i++)
                {
                    sw.WriteLine(ourFactory.listAuto[i].Model + ',' + ourFactory.listAuto[i].Color + ',' + ourFactory.listAuto[i].SerialNumber + ',' +
                        ourFactory.listAuto[i].Price + ',' + ourFactory.listAuto[i].Year + ',' + ourFactory.listAuto[i].Owner);
                }
            }
        }

        public void AssembleFile() // добавляет строки прочитанные из файла в лист<авто> (собирать после добавления всех машин) 
        {
            for (int i = 0; i < arrayAutoData.Rank; i++)
            {
                ourFactory.listAuto.Add(new Auto(arrayAutoData[i, 0], arrayAutoData[i, 1], arrayAutoData[i, 2]
                    , arrayAutoData[i, 3], Convert.ToInt32(arrayAutoData[i, 4]), arrayAutoData[i, 5]));
            }
        }

        public void AddAuto() // добавило строку к финалу
        {
            ourFactory.AddBaseAuto();
            using (StreamWriter sw = new StreamWriter(WriteFilePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(ourFactory.listAuto.Last().Model + ',' + ourFactory.listAuto.Last().Color + ',' + ourFactory.listAuto.Last().SerialNumber + ',' +
                    ourFactory.listAuto.Last().Price + ',' + ourFactory.listAuto.Last().Year + ',' + ourFactory.listAuto.Last().Owner);
            }
        }
    }
}
