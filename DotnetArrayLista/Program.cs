using System;
using System.Data.Common;

namespace DotnetArrayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Formas de inicialização de array:
            int[] meuArray = new int[5];
            var meuArray1 = new int[4];
            //Inicializando com valores. 
            var meuArrayInicializado = new int[5] { 1, 10, 100, 200, 300 };


            Console.WriteLine(meuArray[0]);

            meuArray[0] = 10;
            meuArray[1] = 12;
            meuArray[2] = 15;
            meuArray[3] = 200;
            meuArray[4] = 1200;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);

            var meuArrayStructEx = new Teste[2] { new Teste(), new Teste() };

            Console.WriteLine(meuArrayStructEx[0].Id);

            for (int i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine($"Posição: {i} Valor: {meuArray[i]}");

            }

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }




        }

        struct Teste
        {
            public int Id { get; set; }
        }


        static void ModuloAula1302()
        {
            int[] meuArray = new int[5];

            meuArray[0] = 10;
            meuArray[1] = 12;
            meuArray[2] = 15;
            meuArray[3] = 200;
            meuArray[4] = 1200;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);

            var meuArrayStructEx = new Teste[2] { new Teste(), new Teste() };

            Console.WriteLine(meuArrayStructEx[0].Id);

            for (int i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine($"Posição: {i} Valor: {meuArray[i]}");

            }

            ModuloAula1303();

        }


        static void ModuloAula1303()
        {
            int[] meuArray = new int[5];
            meuArray[0] = 10;
            meuArray[1] = 12;
            meuArray[2] = 15;
            meuArray[3] = 200;
            meuArray[4] = 1200;

            var funcionarios = new Funcinario[5];
            funcionarios[0] = new Funcinario() { Id = 1010, Nome = "Danilo" };
            funcionarios[1] = new Funcinario() { Id = 2020, Nome = "Lu" };
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Id} - {funcionario.Nome}");
            }
        }

        struct Funcinario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }

}