using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dione
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[,] _Array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
                double Max = _Array.Cast<double>().Max();
                double Min = _Array.Cast<double>().Min();
                double Suma = Max + Min;
                Console.WriteLine(Suma + ' ');
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
