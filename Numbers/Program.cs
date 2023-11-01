using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //ModuloAula1202();
            ModuloAula1203();

        }

        //Módulo12: Moedas | Aula02: Formatando moedas
        static void ModuloAula1202()
        {
            var valor = 10.25;
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("de-DE")));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));
        }

        //Módulo12: Moedas | Aula03: Math
        static void ModuloAula1203()
        {
            decimal valor = 10536.25m;
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }
}