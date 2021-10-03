using System;
using System.IO;
using System.Text;

namespace SkillBoxFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Создание файла и запись
            FileStream stream = File.Create("Test.csv");
            stream.Flush();

            DateTime[] Dates = new DateTime[] { Convert.ToDateTime("21.03.20").ToShortDateString, Convert.ToDateTime("10.10.20"), Convert.ToDateTime("01.10.21") };  
            Dates.
            #endregion




            #region Чтение
            using (StreamReader data = new StreamReader("Test.csv", Encoding.Unicode))
            {
                while(!data.EndOfStream)
                {
                    Console.WriteLine(data.ReadLine());
                }

            }
            #endregion
            Console.ReadKey();
        }
    }
}
