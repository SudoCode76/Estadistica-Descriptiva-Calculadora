using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estadistica_Descriptiva_Calculadora
{
  public class marcaDeClase
  {
    public static void marcaClase()
    {
      List<double> marcaClase = ordenarNumeros.numeros;

      var grouped = marcaClase.GroupBy(n => n)
                   .Select(g => new { Numero = g.Key, Count = g.Count() })
                   .OrderBy(x => x.Numero);

      foreach (var grupo in grouped)
      {
        Console.WriteLine("{0,-10} {1,10}",
                    $"-{grupo.Numero}",
                    $"aparece {grupo.Count} veces");
      }
      Console.ReadKey();
    }
  }
}