using System;
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

            //Caso uma condição seja atendida e não queira validar outras condições.
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

            */

            //Utilizando o Swithc
            string valor = "maria";
            switch (valor)
            {
                case "joao": System.Console.WriteLine("Não é o cara."); break;
                case "danilo": System.Console.WriteLine("Esse é o cara."); break;
                case "maria": System.Console.WriteLine("Ou será que é essa?"); break;
                default: System.Console.WriteLine("Não encontrei essa pessoa!"); break;
            }

            //Swithc com null type. Implicitamente ou é true ou false, para aceitar null é necessário no tipo colocar "?"
            bool? valor2 = true;
            switch (valor2)
            {
                case true: System.Console.WriteLine("É Verdadeiro"); break;
                case false: System.Console.WriteLine("É Falso"); break;
                default: System.Console.WriteLine("Não encontrei"); break;

            }














        }
    }
}


