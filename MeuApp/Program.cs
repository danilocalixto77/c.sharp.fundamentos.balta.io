using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);

            int? idade = 46;
            Console.WriteLine(idade);
            idade = null;
            Console.WriteLine(idade);
            idade = 0;
            Console.WriteLine(idade);

        }
    }
}

