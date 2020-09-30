using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Triangulo
{
    class Main
    {
        static void main(String[] args)
        {
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X=" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y=" + areaY.ToString("F4", CultureInfo.InvariantCulture));
            //Imprime na tela o valor encontrado


            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            //Condicional
        }
    }
}
