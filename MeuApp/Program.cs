using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var texto = "Testando";
            Console.WriteLine(texto);

            int? idade = 46;
            Console.WriteLine(idade);
            idade = null;
            Console.WriteLine(idade);
            idade = 0;
            Console.WriteLine(idade);
            
            int inteiro = 100;
            uint interiSemSinal = (uint)inteiro; //Conversão explícita.
            Console.WriteLine(inteiro);

            int outroInteiro = int.Parse("1000"); //Parse
            Console.WriteLine(outroInteiro);

            int inteiro = 100;
            float real = 25.8f;
            //inteiro = real; //Erro não é possivel.
            //real = inteiro; //Permitido
            //inteiro = (int)real; //Conversão explicita
            //inteiro = int.Parse(inteiro); // Erro não é possivel pois o Parse espera uma string
            //string valorReal = real.ToString(); //Convertendo o real para string para  o Parse abaixo
            //inteiro = int.Parse(valorReal); //Parse funcionou pois recebeu uma string.
            inteiro = int.Parse("255");
            inteiro = Convert.ToInt32(real);
            Console.WriteLine(inteiro);
            //Console.WriteLine(valorReal);
            Console.WriteLine(real);

            */

            /*  
            //Operadores aritmeticos
                      
            int x = 2;
            x = 75 / 23 + (2 * 3); //Alterando o operador obtem-se valores conforme operador. + - * /
            Console.WriteLine(x);

            // Operadores de atribuição
            int y = 2;
            y += 5; //Alterando o operador obtem-se valores conforme o operador. + - * /
            y++; // Também pode utilizar ++ ou -- para auto incremento/decremento em loops.
            Console.WriteLine(y);
            
            // Operadores de comparação
            int x = 20;
            Console.WriteLine(x == 10); // False
            Console.WriteLine(x != 10); // True
            Console.WriteLine(x >= 10); // True
            Console.WriteLine(x <= 10); // False
            Console.WriteLine(x > 10); // True
            Console.WriteLine(x < 10); // False            
            
            */

            /*
            //Operadores lógicos
            int x = 12;
            bool andE = (x > 25) && (x < 40); //false
            System.Console.WriteLine($"O operador retornou: {andE}");
            bool orOu = (x > 25) && (x < 40); //true
            System.Console.WriteLine($"O operador retornou: {orOu}");
            bool negacao = !(x < 25); //false
            System.Console.WriteLine($"O operador retornou: {orOu}");

            //Utilizando IF
            int idade = 10;
            int maiorIdade = 21;
            int idadeMaxima = 60;
            if (idade < maiorIdade)
            {
                System.Console.WriteLine("Menor de idade!");
            }
            else if (idade > idadeMaxima)
            {
                System.Console.WriteLine("Idoso!");
            }
            else if (idade <= idadeMaxima)
            {
                System.Console.WriteLine("Jovem!");
            }
            else
            {
                System.Console.WriteLine("Maior de idade!");
            }
            System.Console.WriteLine("Finalizou!");


            if (idade < maiorIdade)
            {
                return;
            }
            else
            {
                System.Console.WriteLine("1");
                System.Console.WriteLine("2");
                System.Console.WriteLine("3");
                System.Console.WriteLine("4");
                System.Console.WriteLine("5");
                System.Console.WriteLine("6");
            }
            
            //Utilizando o Swithc
            string valor = "maria";
            switch (valor)
            {
                case "joao": System.Console.WriteLine("Não é o cara."); break;
                case "danilo": System.Console.WriteLine("Esse é o cara."); break;
                case "maria": System.Console.WriteLine("Ou será que é essa?"); break;
                default: System.Console.WriteLine("Não encontrei essa pessoa!"); break;
            }

            bool? valor2 = true;
            switch (valor2)
            {
                case true: System.Console.WriteLine("É Verdadeiro"); break;
                case false: System.Console.WriteLine("É Falso"); break;
                default: System.Console.WriteLine("Não encontrei"); break;
            }

            //Utilizando o for
            for (var i = 0; i <= 5; i++)
                System.Console.WriteLine($"Contando de 0 a 5: {i}");

            for (var j = 5; j >= 0; j--)
                System.Console.WriteLine($"Contagem regressiva de 5 a 0: {j}");

            for (int k = 1; k <= 5; k++)
            {
                System.Console.WriteLine($"Contando de 1 a 5: {k}");
            }

          
            //Utilizando o while
            int valor = 0;

            while (valor <= 5)
            {
                System.Console.WriteLine(valor);
                valor++;
            }

            valor = 0;
            while (valor <= 5)
            {
                valor++;
                System.Console.WriteLine(valor);
            }

            //loop infitino
            while (true)
            {
                System.Console.WriteLine(valor);
                valor++;
            }


            //Utilizando do/while
            int valor = 0;
            do
            {
                System.Console.WriteLine(valor);
                valor++;
            } while (valor <= 5);

            //Utilizando Métodos
            MeuMetodo();
            string nomeCompleto = RetornaNome("Danilo", "Calixto");
            System.Console.WriteLine(nomeCompleto);

            //Value Type
            int x = 25;
            int y = x; //É feito uma cópia 
            System.Console.WriteLine(x); //x = 25
            System.Console.WriteLine(y); //y = 25
            x = 32;
            System.Console.WriteLine(x); //x = 32
            System.Console.WriteLine(y); //y = 25
            //Reference Type
            var arr1 = new string[2];
            arr1[0] = "Item 1";
            var arr2 = arr1;
            System.Console.WriteLine(arr1[0]); // arr1[0] = "Item 1"
            System.Console.WriteLine(arr2[0]); // arr2[0] = "Item 1"
            arr1[0] = "Item 2";
            System.Console.WriteLine(arr1[0]); // arr1[0] = "Item 2"
            System.Console.WriteLine(arr2[0]); // arr2[0] = "Item 2"
            
            */

            //Uso das structs
            Produto prod = new Produto(1, "Mouse", 5.35f, ETipoDeProduto.ProdutoVirtual);
            prod.Preco = 25.99f;
            System.Console.WriteLine(prod.Id);
            System.Console.WriteLine(prod.Nome);
            System.Console.WriteLine(prod.Preco);
            System.Console.WriteLine(prod.TipoDeProduto);
            System.Console.WriteLine((int)prod.TipoDeProduto);

        }

        static void MeuMetodo()
        {
            System.Console.WriteLine("C# é Legal!!!");
        }

        static string RetornaNome(
            string nome,
            string sobrenome,
            ETipoDeProduto tipo,
            int idade = 46, //parâmetros opcionais
            double altura = 1.85, //parâmetros opcionais
            bool teste = true //parâmetros opcionais

            )
        {
            return nome + " " + sobrenome + " " + idade.ToString();
        }

        struct Produto
        {
            public Produto(int id, string nome, double preco, ETipoDeProduto tipoDeProduto)
            {
                Id = id;
                Nome = nome;
                Preco = preco;
                TipoDeProduto = tipoDeProduto;
            }

            public int Id;
            public string Nome;
            public double Preco;
            public ETipoDeProduto TipoDeProduto;

            public double PrecoEmDolar(double dolar)
            {
                return Preco * dolar;
            }

        }

        enum ETipoDeProduto
        {
            ProdutoFisico = 1,
            ProdutoVirtual = 2,
            ServicoPresencial = 3
        }



    }


}


