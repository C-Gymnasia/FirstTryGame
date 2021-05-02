using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FirstGameTry
{
    class Program
    {
        public static char[,] mainField;
        static void Main(string[] args)
        {
            #region CreateField
            char[,] field = new char[10,5];
            char fieldChar = '*';
            for(int y = 0; y < 5; y++)
            {
                for(int x = 0; x < 10; x++)
                {
                    field[x, y] = fieldChar;
                }
            }
            mainField = field;
            #endregion
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Elapsed += PrintField;
            timer.Start();
            Console.ReadLine();
        }

        private static void PrintField(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(mainField[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
