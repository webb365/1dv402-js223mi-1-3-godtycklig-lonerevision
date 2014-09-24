using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MyExtensions calc = new MyExtensions();
               int[] value = ReadSalaries(ReadInt(Properties.Resources.Pay_Count));
               calc.Median(value);
            } while (IsContinuing());
        }
        static int ReadInt(string prompt)
        {
            string text;
            int value;
            while (true)
            {
                Console.Write(prompt);
                text = Console.ReadLine();
                try
                {
                    value = int.Parse(text);
                    if (value < 2)
                        throw new ArgumentOutOfRangeException();
                    return value;
                }
                catch (Exception ex )
                {
                    if (ex is ArgumentOutOfRangeException)
                        ViewMessage(Properties.Resources.Minimum_Pay, ConsoleColor.Red);
                    else
                        ViewMessage(string.Format(Properties.Resources.Error_Pay,text), ConsoleColor.Red);
                }

            }
        }
        static int[] ReadSalaries(int count) 
        {
            int[] pay = new int[count];
            for (int i = 0; i < count; i++)
            {
               pay[i] = ReadInt(string.Format(Properties.Resources.Get_pay,i+1));
            }
            return pay;
        }

        static void ViewResult(int[] salaries)
        { 
        
        }
        static bool IsContinuing()
        {
            bool stop;
            ViewMessage(Properties.Resources.Continue_Prompt);
            stop = Console.ReadKey(true).Key != ConsoleKey.Escape;
            if (stop)
            {
                Console.Clear();

            }
            return stop;
        }

        private static void ViewMessage(string message,ConsoleColor backgroundColor = ConsoleColor.Blue,ConsoleColor foregroundColor = ConsoleColor.White)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine("\n {0}", message);
            Console.ResetColor();
        }
    }
}
