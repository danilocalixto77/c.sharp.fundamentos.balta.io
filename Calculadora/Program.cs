﻿using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            // Console.WriteLine("O resultado da soma é: ");
            // Console.WriteLine(resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            // Console.WriteLine(valor1 + valor2);
        }
    }
}