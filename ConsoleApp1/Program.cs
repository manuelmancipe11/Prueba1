using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Digite un número:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite un número:");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine(calculadora.Sumar(numero1, numero2));
            Console.ReadKey();
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
