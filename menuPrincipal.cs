using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estadistica_Descriptiva_Calculadora
{
    public class menuPrincipal
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("----- Calculadora Est. Desriptiva By Sudo -----");
            Console.WriteLine("1. Calcular rango (proximamente)");
            Console.WriteLine("2. Calcular numero de intervalos (proximamente) ");
            Console.WriteLine("3. Calcular Amplitud (proximamente)");
            Console.WriteLine("4. Ordernar numeros de mayor a menor");
            Console.WriteLine("5. Mostrar todos los numeros ingresados");
            Console.WriteLine("6. Mostrar marca de clase");
            Console.WriteLine("7. Eliminar datos");
            Console.WriteLine("8. Salir");
            Console.Write("Selecciona una opción: ");
        }

    }
}