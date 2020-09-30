using System;
//Nome: Julio Cesar Henrique e Silva RA: 142150
//Exercicio: Calcular a area de um triangulo

namespace Triangulo
{
    class Program
    {
        public double A;
        public double B;
        public double C;
        //Declaração de variaveis

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
            //Calculo para achar a area desejada
        }

        static void Main(string[] args)
        {
            
        }
    }
}
