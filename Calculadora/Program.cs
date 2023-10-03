using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine(valor1);
        }
    }
}