using System;

namespace DotnetArrayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Formas de inicialização de array:
            int[] meuArray = new int[3];
            var meuArray1 = new int[4];
            //Inicializando com valores. 
            var meuArrayInicializado = new int[5] { 1, 10, 100, 200, 300 };


            Console.WriteLine(meuArray[0]);

            meuArray[0] = 10;
            meuArray[1] = 12;
            meuArray[1] = 15;
            meuArray[1] = 200;
            meuArray[1] = 1200;

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);

            var meuArrayStructEx = new Teste[2] {new Teste(), new Teste()};

            Console.WriteLine(meuArrayStructEx[0].Id);

        }

        struct Teste
        {
            public int Id { get; set; }
        }

    }

}