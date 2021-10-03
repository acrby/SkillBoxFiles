using System;
using System.IO;
using System.Text;

namespace SkillBoxFiles
{
    class Program
    {

        /// <summary>
        /// Самописный метод создания файла и его заполнения тестовыми данными
        /// </summary>
        /// <param name="filename">Имя файла, который будет создан в директории Решения</param>
        static void CreateAndWriteFile(string filename)
        {
            #region Создание файла и запись
            FileStream stream = File.Create(filename);
            stream.Close();

            DateTime[] dates = new DateTime[] { Convert.ToDateTime("21.03.20"), Convert.ToDateTime("10.10.20"), Convert.ToDateTime("01.10.21") };
            string[] note = new string[] { "Сходить в магазин", "Поесть булки", "Перечислить деньги" };
            bool[] warning = new bool[] { false, true, true };
            string fullMark;

            using (StreamWriter data = new StreamWriter(filename, true, Encoding.Unicode))
            {
                for (int index = 0; index < note.Length; index++)
                {
                    fullMark = dates[index].ToShortDateString() + "\t" + note[index] + "\t" + warning[index] + "\t";
                    data.WriteLine(fullMark);
                }

            }
            #endregion
        }

        /// <summary>
        /// Самописная функция чтения файла
        /// </summary>
        /// <param name="filename">Имя файла с расширением, которое будет прочитано в директории Решения</param>
        static void ReadFile(string filename) //com
        {
            #region Чтение
            using (StreamReader data = new StreamReader(filename, Encoding.Unicode))
            {
                string line;
                while (!data.EndOfStream)
                {
                    while ((line = data.ReadLine()) != null)
                    {
                        string[] datastring = line.Split('\t');
                        Console.WriteLine($"{datastring[0],-15} {datastring[1],-20} {datastring[2],7}");
                    }
                }

            }
            #endregion
        }


        /// <summary>
        /// Ебучий метод Main
        /// </summary>
        /// <param name="args">Параметры которые залетают, их описание</param>
        static void Main(string[] args)
        {
            string filename = "Test.xls";
            CreateAndWriteFile(filename);
            ReadFile(filename);

            Console.ReadKey();
        }
    }
}
