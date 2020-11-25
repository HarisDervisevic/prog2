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

        public static int calculation(string expression)
        {
            
           string[] list = expression.Split('+', '-', '÷', '⋅');
            var value1 = Convert.ToDouble(list[0]);
            var value2 = Convert.ToDouble(list[1]);

            if (.contain.expression == " + ")
            {
                var result = value1 + value2;

            }

            else if(operation == "-"){

                var result = value1 - value2;

            }

            else if (operation == "÷")
            {
                var result = value1 / value2;

            }

            else if (operation == "⋅")
            {

                var result = value1 * value2;

            }


            // var talet(string) = Text.split('+');
            // tal1 = Convert.ToInt32(talet(string)[0])
            return 0;

        }

    }
}
