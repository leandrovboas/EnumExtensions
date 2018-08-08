using ConsoleEnumExtensions;
using EnumExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ConsoleEnumUtilss
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
            Console.WriteLine("\t --------------- Testes com EnumUtils ---------------");
            Console.WriteLine("\t Digite 1 para executar AsUpperCamelCaseName");
            Console.WriteLine("\t Digite 2 para executar GetEnumDescription");
            Console.WriteLine("\t Digite 3 para executar GetDisplayName");
            Console.WriteLine("\t Digite 4 para executar GetDisplay");
            Console.WriteLine("\t Digite 5 para executar EnumToList");
            Console.WriteLine("\t Digite 6 para executar ParseEnum");
            Console.WriteLine("\t Digite 7 para executar EnumToDictionary");
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
                    GetDisplay();
                    break;
                case '5':
                    EnumToList();
                    break;
                case '6':
                    ParseEnum();
                    break;
                case '7':
                    EnumToDictionary();
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
            foreach (EnumDayOfWeek item in Enum.GetValues(typeof(EnumDayOfWeek)))
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
            foreach (EnumDayOfWeek item in Enum.GetValues(typeof(EnumDayOfWeek)))
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
            foreach (EnumDayOfWeek item in Enum.GetValues(typeof(EnumDayOfWeek)))
            {
                Console.WriteLine($"\t\tName:{item} - {item.GetDisplay()}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

        private static void EnumToList()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- EnumToList ---------------");

            var weekdays = EnumUtils.EnumToList<EnumDayOfWeek>().ToList();
            foreach (var item in weekdays)
            {
                Console.WriteLine($"\t\tName:{item}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

        private static void ParseEnum()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- ParseEnum ---------------");
            var enumString = EnumUtils.ParseEnum<EnumDayOfWeek>("Wed");
            var enumInt = EnumUtils.ParseEnum<EnumDayOfWeek>(4);
            Console.WriteLine($"\t\t Parse Enum String:'Wed' -  {enumString} - type:({enumString.GetType().Name})");
            Console.WriteLine($"\t\t Parse Enum Int:4 -  {enumInt} - type:({enumInt.GetType().Name})");
            Console.ReadKey();
            RecarregarMenu();
        }

        private static void EnumToDictionary()
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------- EnumToDictionary ---------------");

            var dictionary = EnumUtils.EnumToDictionary<EnumDayOfWeek>();
                foreach (KeyValuePair<int, string> entry in dictionary)
            {
                Console.WriteLine($"\t\t Key:{entry.Key} - value:{entry.Value}");
            }
            Console.ReadKey();
            RecarregarMenu();
        }

    }
}
