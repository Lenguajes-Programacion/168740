using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegirPrograma
{
    class Name
    {
        public string nombre = "Erick";
        string n = "";
        int contra = 6969;
        int pass;
        public void Erick()
        {        
            Console.WriteLine("Escribe el nombre");
            n = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Escribe la contrasena");
            pass = int.Parse(Console.ReadLine());

            if (n == nombre && pass == contra) //true o false.
            {
                Console.WriteLine();
                Console.WriteLine("Hello" + n);
            }
            else
            {
                Console.WriteLine("usuario autorizado");
            }
        }

    }
}


















