using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordLib
{
    public class NumberToWordConvertor
    {
        public static string ConvertNumberToWord(double number)
        {
            number = Math.Round(number,2);
            string[] splitter = number.ToString().Split('.');
            int intPart = int.Parse(splitter[0]);
            int decPart;
            string words;
            if (splitter.Length > 1)
            {
                decPart = int.Parse(splitter[1]);
                words = NumberToWord(intPart) + "-" + NumberToWord(decPart) + " Cents";
            }
            else
            {
                words = NumberToWord(intPart);
            }
            return words;
           
        }

        public static string NumberToWord(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Minus " + NumberToWord(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWord(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWord(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWord(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " +unitsMap[number % 10];
                }
            }

            return words;            
        }
        
    }
}
