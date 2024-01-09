using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Estadistica_Descriptiva_Calculadora
{
  public class ordenarNumeros
  {
    public static List<double> numeros = new List<double>();

    public static void ordNumeros()
    {
      Console.Clear();
      Console.WriteLine("Ingresa una serie de números separados por un ('-'';''espacio'):");
      string input = Console.ReadLine();

      char[] separators = { '-', ';', ' ' };
      string[] numberStrings = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

      
      foreach (var numberString in numberStrings)
      {
        if (double.TryParse(numberString, out double numero))
        {
          numeros.Add(numero);
        }
        else
        {
          Console.WriteLine($"'{numberString}' no es un número válido y será ignorado.");
        }
      }

      numeros.Sort();

      Console.Clear();
      Console.WriteLine("Números ordenados de menor a mayor:");
      foreach (var numero in numeros)
      {
        Console.Write(numero + " ");
      }
      Console.ReadKey();
    }
  }
}