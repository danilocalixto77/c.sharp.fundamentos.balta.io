using System;
using System.Collections;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação Deseja?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecione uma opção: ");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

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
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Valor: ");
            float valorsub1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor: ");
            float valorsub2 = float.Parse(Console.ReadLine());
            float resultadosub = valorsub1 - valorsub2;
            Console.WriteLine("");
            Console.WriteLine($"O Resultado da Subtração é: {resultadosub}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Valor da Divisão: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor da Divisão: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 / valor2;
            Console.WriteLine("");
            Console.WriteLine($"O Resultado da Divisão foi: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digte o primeiro Valor da Multiplicaçao: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = valor1 * valor2;
            Console.WriteLine("O Resultado da multiplicação é: " + (valor1 * valor2));
            Console.ReadKey();
            Menu();
        }


    }
}