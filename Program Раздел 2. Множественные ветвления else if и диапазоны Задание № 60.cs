using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program60
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Стаж (лет): ");
            if (double.TryParse(Console.ReadLine(), out double years) && years >= 0)
            {
                double bonus;
                if (years < 1) bonus = 0;
                else if (years <= 5) bonus = 5;
                else if (years <= 10) bonus = 10;
                else bonus = 15;

                Console.WriteLine($"Надбавка: {bonus}%");
            }
            else
            {
                Console.WriteLine("Ошибка: стаж неотрицателен.");
            }
        }
    }
}