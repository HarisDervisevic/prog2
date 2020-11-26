using System;
using System.Collections.Generic;
using System.Text;

namespace oop_uppgift
{
    class calculations
    {

        public calculations()
        {
            
        }

        public static string calculation(string expression)
        {

            string[] list = expression.Split('+', '-', '÷', '⋅', '^', '√');
            var value1 = Convert.ToDouble(list[0]);
            var value2 = Convert.ToDouble(list[1]);

            if (expression.Contains("+"))
            {
                var result = value1 + value2;
                expression += "=" + result;

            }

            else if (expression.Contains("-"))
            {
                var result = value1 - value2;
                expression += "=" + result;

            }

            else if (expression.Contains("÷"))
            {
                var result = value1 / value2;
                expression += "=" + result;

            }

            else if (expression.Contains("⋅"))
            {

                var result = value1 * value2;
                expression += "=" + result;

            }

            else if (expression.Contains("^"))
            {

                var result = Math.Pow(value1, value2);
                expression += "=" + result;

            }

            else
            {
                Squrt_function(expression);
            }
            return expression;
     

        }




        public static string Squrt_function(string expression)
        {

               if (expression.Contains("√"))
            {
                char[] charArr = expression.ToCharArray();

                var result = Math.Sqrt(charArr[1] + charArr[2]);
                expression += "=" + result;

               
        }
            return expression;
        }

    }
}
