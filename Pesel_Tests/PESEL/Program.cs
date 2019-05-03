using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer pesel");
            string number = Console.ReadLine();
            var pesel = new PeselInfo(number);
            pesel.SetDate();
            pesel.SetGender();
            pesel.CheckPeselLength();
            pesel.CheckSumControl();
            pesel.AreDigits();


            Console.ReadKey();

        }
    }
}
