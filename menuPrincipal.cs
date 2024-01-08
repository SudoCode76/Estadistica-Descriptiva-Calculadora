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
            Console.WriteLine("1. Calcular rango");
            Console.WriteLine("2. Calcular numero de intervalos");
            Console.WriteLine("3. Calcular Amplitud");
            Console.WriteLine("4. Ordernar numeros de mayor a menor");
            Console.WriteLine("5. Mostrar marca de clase");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");
        }

    }
}