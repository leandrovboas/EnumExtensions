using System;
using System.Net;
using EnumExtensions;

namespace ConsoleEnumExtensions
{
    class Program
    {
        static void Main() =>
            CarregarMenu();

        private static void CarregarMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t --------------------- Menu Inicial ---------------------");
            Console.WriteLine("\t --------------- Testes com EnumExtension ---------------");
            Console.WriteLine("\t Digite 1 para executar AsUpperCamelCaseName");
            Console.WriteLine("\t Digite 2 para executar GetEnumDescription");
            Console.WriteLine("\t Digite 3 para executar GetDisplayName");
            Console.WriteLine("\t Digite 4 para executar GetDisplay");
            Console.Write("\t\t");
            var key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    AsUpperCamelCaseName();
                    break;
                case '2':
                    GetEnumDescription();
                    break;
                case '3':
                    GetDisplayName();
                    break;
                case '4':
                    GetDisplayName();
                    break;
                default:
                    break;
            }
        }

        private static void RecarregarMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t Pressione qualquer tecla para recarregar o menu");
            CarregarMenu();
        }

        private static void AsUpperCamelCaseName()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- AsUpperCamelCaseName ---------------");
            foreach (HttpStatusCode statusCode in Enum.GetValues(typeof(HttpStatusCode)))
            {
                Console.WriteLine($"\t\tName:{statusCode.ToString().PadRight(30)} - Display Name:{statusCode.AsUpperCamelCaseName()}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

        private static void GetEnumDescription()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- GetEnumDescription ---------------");
            foreach (DayOfWeek item in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"\t\tName:{item} - {item.GetEnumDescription()}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

        private static void GetDisplayName()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- GetDisplayName ---------------");
            foreach (DayOfWeek item in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"\t\tName:{item} - {item.GetDisplayName()}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

        private static void GetDisplay()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- GetDisplay ---------------");
            foreach (DayOfWeek item in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine($"\t\tName:{item} - {item.GetDisplay()}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

    }
}
