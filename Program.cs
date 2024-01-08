using Estadistica_Descriptiva_Calculadora;

class Program
{
  static void Main(string[] args)
  {
    menuPrincipal.MostrarMenu();
    while (true)
    {
      string opcion = Console.ReadLine();

      switch (opcion)
      {
        case "1":
          Console.WriteLine("Calcular rango");
          break;
        case "2":
          Console.WriteLine("Calcular numero de intervalos");
          break;
        case "3":
          Console.WriteLine("Calcular Amplitud");
          break;
        case "4":
          Console.Clear();
          Console.WriteLine("Ordernar numeros de mayor a menor");
          ordenarNumeros.ordNumeros();
          
          break;
        case "5":
          Console.WriteLine("Mostrar marca de clase");
          break;
        case "6":
          Console.WriteLine("Saliendo del programa...");
          return;
        default:
          Console.WriteLine("Opción no válida. Por favor, selecciona una opción del menú.");
          break;
      }

      menuPrincipal.MostrarMenu();
    }
  }
}