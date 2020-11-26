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

            //När den fått hela inputen så kommer den att dela upp det till det inann givet tecken och det efter tecken i 
            //en lista där de sedan görs om till en variabel

            string[] list = expression.Split('+', '-', '÷', '⋅', '^', '√');
            var value1 = Convert.ToDouble(list[0]);
            var value2 = Convert.ToDouble(list[1]);

            //kollar ifall användaren valt angivet tecken, om den har så sker uträckingen och tillbaka får du svar,
            //annars kommer den fortsätta ner tills den hittar de rätta teckent
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
            return expression;
     

        }



        /*
        public static string Squrt_function(string expression)
        {

               if (expression.Contains("√"))
            {
                char[] charArr = expression.ToCharArray();

                var result = Math.Sqrt(charArr[0] + charArr[1]);
                expression += "=" + result;


            }
            return expression;
        */
        }

    }

