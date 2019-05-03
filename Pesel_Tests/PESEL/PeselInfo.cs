using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL
{
    public class PeselInfo
    {
        public bool DigitsOnly { get; set; }
        public string Gender { get; set; }
        public int Sum { get; set; } = 0;
        public string Number { get; set; }
        private DateTime dateValue;

        public PeselInfo(string number)
        {
            this.Number = number;
        }

        public string SetDate()
        {
            if (AreDigits() == true)
            {
                if (!DateTime.TryParseExact(this.Number.Substring(0, 6), "yymmdd", CultureInfo.InstalledUICulture, DateTimeStyles.None, out dateValue))
                {
                    throw new FormatException("Date is not in correct format");
                }
                Console.WriteLine($"Date of birth: {dateValue.ToString("dd-mm-yy")}");
                return dateValue.ToString("dd-mm-yy");
            }
            throw new IndexOutOfRangeException("Only numeric value");

        }
        public string SetGender()
        {
            if (AreDigits() == true)
            {
                int itemCount = int.Parse(this.Number.Substring(9, 1));
                Gender = (itemCount % 2 == 0) ? "W" : "M";
                Console.WriteLine($"Gender: {Gender}");
                return Gender;
            }
            throw new IndexOutOfRangeException("Only numeric value");
        }
        public bool AreDigits()
        {
            var theString = Number;
            return DigitsOnly = theString.All(char.IsDigit);

        }

        public int CheckPeselLength()
        {
            if (Number.Length != 11)
            {
                throw new FormatException("Amout of characters is wrong");
            }
            else
                Console.WriteLine($"Length of pesel is equal: {Number.Length}");
            return Number.Length;
        }
        public int CheckSumControl()
        {

            int[] tab = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };
            for (int i = 0; i < tab.Length; i++)
            {
                Sum += tab[i] * Number[i];
            }
            if (Sum % 10 == 0)
            {
                Console.WriteLine("Pesel is correct");
                return Number[10];
            }
            else
                throw new FormatException("Pesel is incorrect");
           
        }
    }

}