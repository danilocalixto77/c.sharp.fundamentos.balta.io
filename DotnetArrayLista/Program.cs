using System;
using System.Data.Common;

namespace DotnetArrayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //ModuloAula1301();
            //ModuloAula1302();
            //ModuloAula1303();
            //ModuloAula1304();
            //ModuloAula1402();
            ModuloAula1403();
            //ModuloAula1404("");
        }

        struct Teste
        {
            public int Id { get; set; }
        }

        //Modulo: 13 - Arrays | Aula: 01 - Arrays
        static void ModuloAula1301()
        {
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
        }

        //Modulo: 13 - Arrays | Aula 02: Percorrendo um array
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
        }

        //Modulo: 13 - Arrays | Aula 03: ForEach
        static void ModuloAula1303()
        {
            int[] meuArray = new int[5];
            meuArray[0] = 10;
            meuArray[1] = 12;
            meuArray[2] = 15;
            meuArray[3] = 200;
            meuArray[4] = 1200;

            Console.WriteLine("ForEach de um array de inteiros");
            Console.WriteLine("----------------------------------");
            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ForEach de um array de inteiros");
            Console.WriteLine("----------------------------------");
            var funcionarios = new Funcinario[5];
            funcionarios[0] = new Funcinario() { Id = 1010, Nome = "Danilo" };
            funcionarios[1] = new Funcinario() { Id = 2020, Nome = "Lu" };
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.Id} - NOME: {funcionario.Nome}");
            }
        }

        struct Funcinario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        //Modulo: 13 - Arrays | Aula 04: Alterando os valores
        static void ModuloAula1304()
        {
            //Exemplo de atribuição por referência:
            var arr1 = new int[4];
            var arr2 = arr1;
            arr1[0] = 23;
            Console.WriteLine($"{arr1[0]} {arr2[0]}");

            //Exemplo de atribuição para um novo array.
            var arr3 = new int[4];

            arr1[0] = arr3[0];

            arr3[0] = 15;

            Console.WriteLine($"{arr1[0]} {arr3[0]}");

        }

        //Modulo: 14 - Arrays | Aula 02: Try/Catch
        static void ModuloAula1402()
        {
            var arr = new int[3];

            try
            {
                for (var i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"{arr[i]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ops... Algo errado!");
                Console.WriteLine($"InnerException : {ex.InnerException}");
                Console.WriteLine($"Mensagem : {ex.Message}");
            }

        }

        //Modulo: 14 - Arrays | Aula 03: Tratando erros
        static void ModuloAula1403()
        {
            var arr = new int[3];

            try
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"{arr[i]}");
                }
                //Salvar("");
                SalvarNewException("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Índice fora do range do array.");
                Console.WriteLine($"InnerException : {ex.InnerException}");
                Console.WriteLine($"Mensagem : {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Falha ao cadastrar texto vazio ou nulo.");
                Console.WriteLine($"InnerException : {ex.InnerException}");
                Console.WriteLine($"Mensagem : {ex.Message}");
            }
            catch (MinhaException ex)
            {

                Console.WriteLine($"InnerException : {ex.InnerException}");
                Console.WriteLine($"Mensagem : {ex.Message}");
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine($"Exceção customizada!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ops... Algo errado!");
                Console.WriteLine($"InnerException : {ex.InnerException}");
                Console.WriteLine($"Mensagem : {ex.Message}");
            }

        }

        //Modulo: 14 - Arrays | Aula 03: Tratando erros
        static void ModuloAula1404(string textoTeste)
        {
            Salvar(textoTeste);
            SalvarNewException(textoTeste);
        }

        static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new ArgumentException("O texto não pode ser nulo ou vazio (throw)!");

        }

        static void SalvarNewException(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);

        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime data)
            {
                QuandoAconteceu = data;
            }

            public DateTime QuandoAconteceu { get; set; }
        }



    }

}