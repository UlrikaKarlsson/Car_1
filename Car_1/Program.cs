using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_1
{
    class Program
    {
        class Car
        {
            private string carBrand, yearModel;
            private int numOfMil = 0;
            public Car (string C, string Y, int M)
            {
                carBrand = C;
                yearModel = Y;
                numOfMil = M;
            }
            public int NumOfMil()
            {
                return numOfMil;
            }
        }
        static void Main(string[] args)
        {
            Car C = new Car("Lada", "1990", 137682);
            Console.WriteLine("Antal mil = {0}", C.NumOfMil());
        }
    }
}
