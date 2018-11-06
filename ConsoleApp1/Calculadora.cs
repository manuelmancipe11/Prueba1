using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calculadora
    {
        public int Sumar(int numero1, int numero2)
        {
            return (numero1 + numero2);
        }

        public int Restar(int minuendo, int sustraendo)
        {
            if (minuendo < sustraendo)
            {
                throw new InvalidOperationException("operacion invalida");
            }
            return minuendo - sustraendo;
        }

        public int Dividir( int dividendo, int divisor)
        {
            if(divisor < 1)
            {
                throw new InvalidOperationException("No puede dividir entre cero");
            }
            return dividendo/divisor;
        }
    }
}
