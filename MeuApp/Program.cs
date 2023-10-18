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
            /*
            Produto prod = new Produto(1, "Mouse", 5.35f, ETipoDeProduto.ProdutoVirtual);
            prod.Preco = 25.99f;
            System.Console.WriteLine(prod.Id);
            System.Console.WriteLine(prod.Nome);
            System.Console.WriteLine(prod.Preco);
            System.Console.WriteLine(prod.TipoDeProduto);
            System.Console.WriteLine((int)prod.TipoDeProduto);
            */

            //ModuloAula0505();
            //ModuloAula0506();
            //ModuloAula0526();
            //ModuloAula0530();
            //ModuloAula0531();
            //ModuloAula0533();
            //ModuloAula0534();
            //ModuloAula0535();
            //ModuloAula0536();
            //ModuloAula0537();

            //ModuloAula0539 - Metodos
            //MeuMetodo();
            var retorno = "";
            retorno = RetornaNome("Danilo Holanda Calixto", "Calixto", ETipoDeProduto.ProdutoVirtual);
            Console.WriteLine(retorno);


            //ModuloAula0901();
            //ModuloAula0902();
            //ModuloAula0903();
            //ModuloAula0904();
            //ModuloAula0905();

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


        //Módulo05: Linguagem de Programação com C# | Aula05: Variáveis
        static void ModuloAula0505()
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

        //Módulo05: Linguagem de Programação com C# | Aula06: Constantes
        static void ModuloAula0506()
        {
            //const int IDADE_MINIMA; //Inicia com zero
            const int IDADE_MINIMA = 18;
            Console.WriteLine(IDADE_MINIMA);

        }

        //Módulo05: Linguagem de Programação com C# | Aula26: Convertendo tipos
        static void ModuloAula0526()
        {
            int inteiro = 100;
            uint interiSemSinal = (uint)inteiro; //Conversão explícita.
            Console.WriteLine(inteiro);

            int outroInteiro = int.Parse("1000"); //Parse
            Console.WriteLine(outroInteiro);
            inteiro = 100;
            float real = 25.8f;

            //inteiro = real; //Erro não é possivel.

            real = inteiro; //Permitido
            inteiro = (int)real; //Conversão explicita

            //inteiro = int.Parse(inteiro); // Erro não é possivel pois o Parse espera uma string
            string valorReal = real.ToString(); //Convertendo Real para string 

            //inteiro = int.Parse(valorReal); //Parse funcionou pois recebeu uma string.

            inteiro = int.Parse("255");
            inteiro = Convert.ToInt32(real);
            Console.WriteLine(inteiro);
            Console.WriteLine(valorReal);
            Console.WriteLine(real);
        }

        //Módulo05: Linguagem de Programação com C# | Aula30: utilizando operadores
        static void ModuloAula0530()
        {
            //Aritméticos
            int x = 2;
            x = 75 / 23 + (2 * 3);
            //Alterando o operador obtem-se valores conforme operador. + - * /
            Console.WriteLine(x);

            //Atribuição
            int y = 2;
            y += 5; //Alterando o operador obtem-se valores conforme o operador. + - * /
            y++; // Também pode utilizar ++ ou -- para auto incremento/decremento em loops.
            Console.WriteLine(y);

            //Comparação
            x = 20;
            Console.WriteLine(x == 10); // False
            Console.WriteLine(x != 10); // True
            Console.WriteLine(x >= 10); // True
            Console.WriteLine(x <= 10); // False
            Console.WriteLine(x > 10); // True
            Console.WriteLine(x < 10); // False

        }

        //Módulo05: Linguagem de Programação com C# | Aula31: Operadores lógicos
        static void ModuloAula0531()
        {
            int x = 12;
            bool andE = (x > 25) && (x < 40); //false
            System.Console.WriteLine($"O operador retornou: {andE}");
            bool orOu = (x > 25) && (x < 40); //true
            System.Console.WriteLine($"O operador retornou: {orOu}");
            bool negacao = !(x < 25); //false
            System.Console.WriteLine($"O operador retornou: {orOu}");
        }

        //Módulo05: Linguagem de Programação com C# | Aula33: Utilizando IF
        static void ModuloAula0533()
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula33: Utilizando IF");
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
        }

        //Módulo05: Linguagem de Programação com C# | Aula34: Estrutura condicional: Switch
        static void ModuloAula0534()
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula34: Estrutura condicional: Switch");
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
        }

        //Módulo05: Linguagem de Programação com C# | Aula35: Laços de repetição: For
        static void ModuloAula0535()
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula35: Laços de repetição: For");

            for (var i = 0; i <= 5; i++)
                System.Console.WriteLine($"Contando de 0 a 5: {i}");

            for (var j = 5; j >= 0; j--)
                System.Console.WriteLine($"Contagem regressiva de 5 a 0: {j}");

            for (int k = 1; k <= 5; k++)
            {
                System.Console.WriteLine($"Contando de 1 a 5: {k}");
            }
        }

        //Módulo05: Linguagem de Programação com C# | Aula36: Laços de repetição: While
        static void ModuloAula0536()
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula36: Laços de repetição: While");
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
                if (valor == 15)
                    break;
            }
        }

        //Módulo05: Linguagem de Programação com C# | Aula37: Laços de repetição: Do/While
        static void ModuloAula0537()
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula37: Laços de repetição: Do/While");
            int valor = 0;
            do
            {
                System.Console.WriteLine(valor);
                valor++;
            } while (valor <= 5);
        }

        //Módulo05: Linguagem de Programação com C# | Aula39: Métodos e funções:Prática
        static void MeuMetodo()
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula39: Métodos e funções:Prática");
            System.Console.WriteLine("C# é Legal!!!");
        }
        //Módulo05: Linguagem de Programação com C# | Aula39: Métodos e funções:Prática
        static string RetornaNome(
            string nome,
            string sobrenome,
            ETipoDeProduto tipo,
            int idade = 46, //parâmetros opcionais
            double altura = 1.85, //parâmetros opcionais
            bool teste = true //parâmetros opcionais
            )
        {
            Console.WriteLine("Módulo05: Linguagem de Programação com C# | Aula39: Métodos e funções:Prática");
            return nome + " " + sobrenome + " " + idade.ToString();
        }


        //Módulo09: Strings | Aula01: Guids
        static void ModuloAula0901()
        {
            //Gera novo id
            var id = Guid.NewGuid();
            id.ToString();
            //Ao converter para um tipo String pode-se trabalhar com o Guid de várias formas
            Console.WriteLine(id);

            //Gera id zerado - ERRO COMUM
            id = new Guid();
            Console.WriteLine(id);

            //Informando Guid vazio. Irá ocorrer uma Exception.
            //id = new Guid(""); 
            //Informando Guid válido
            id = new Guid("432a5b7c-60ba-49af-98bb-75326592f854");

            //Retorna o Guid atribuido a id
            Console.WriteLine(id);
        }

        //Módulo09: Strings | Aula02: Interpolação de strings
        static void ModuloAula0902()
        {
            //1º Forma simples, concatenando variáveis
            var preco = 10.2;
            var texto = "O Preço do Produto é " + preco + " Reais.";
            Console.WriteLine(texto);
            //2º Forma com Format que formata uma cadeia de caracteres.
            texto = string.Format("O preço do produto é {0} Reais. {1}", preco, true);
            Console.WriteLine(texto);
            //3º Forma com cifrão $
            texto = $"O preço do produto é {preco} reais";
            Console.WriteLine(texto);
            //Dica: Uso do @. I irá quebrar a linha ou o C# ignora comandos como \n.
            texto = $@"O preço do produto é {preco} reais,
                      somente para compras em promoção, 
                      com uso do Arroba.";
            Console.WriteLine(texto);
        }

        //Módulo09: Strings | Aula03: Comparação de strings
        static void ModuloAula0903()
        {
            var texto = "Testando";
            //Metodo CompareTo retorna 0 ou 1.
            Console.WriteLine($"Variável= {texto}" + " Digitado= Testando " + texto.CompareTo("Testando")); //0 Achou
            Console.WriteLine($"Variável= {texto}" + " Digitado= testando " + texto.CompareTo("testando")); //1 Não Achou

            //Metodo Contains retorna True ou False
            texto = "Este texto é um teste do método Contains.";
            Console.WriteLine(texto.Contains("teste")); //True Case sensitive
            Console.WriteLine(texto.Contains("TESTE", StringComparison.OrdinalIgnoreCase)); //True Para ignorar Case sensitive
        }

        //Módulo09: Strings | Aula04: StarsWith/EndsWith
        static void ModuloAula0904()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("TESTE"));
        }

        //Módulo09: Strings | Aula05: Equal
        static void ModuloAula0905()
        {
            Console.WriteLine("Módulo09: Strings | Aula05: Equal");
            var texto = "Este texto é um teste";
            var idade = 46;
            var nome = "Danilo";
            //Comparando valores da variável
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("ESTE TEXTO É UM TESTE"));
            Console.WriteLine(texto.ToUpper().Equals("ESTE TEXTO É UM TESTE"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
            //Comparando tipos de objetos/variáveis
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(texto.Equals(idade));
            Console.WriteLine(texto.Equals(nome));

        }
    }


}



