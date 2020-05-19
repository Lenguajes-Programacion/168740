using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ElegirPrograma
{
    class Program
    {
        public void Main(string[] args)
        {
            string eleccion = "";
            string continuar = "si";

            while (continuar == "si")
            {
                Console.WriteLine("\nPROGRAMA PRINCIPAL");

                Console.WriteLine();

                Console.WriteLine("Elija el programa que desea usar");
                Console.WriteLine("1 para Calculadora");
                Console.WriteLine("2 para Nombre");

                eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                        Calculadora c1 = new Calculadora();
                        c1.Usar();
                        break;

                    case "2":
                        Name c2 = new Name();
                        c2.Erick();
                        break;

                    default:
                        Console.WriteLine("Opción no disponible");
                        break;
                }

                Console.WriteLine("\nUsted esta en el programa principal");
                Console.WriteLine("¿Desea continuar?");
                continuar = Console.ReadLine();

            }

            Console.ReadKey();
        }
    }
}
