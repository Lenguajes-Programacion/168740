using System;

namespace ConsoleApp1
{
    class Program
    {

        //Variable de la clase.
        static string nombre = "Erick";


        static void Main(string[] args)

        {
            //Respondemos con el primer argumento.
            //condicion se debe cuplior todas las sentencias si utilizamos las sentincias &&
            //se debe cumplir una de las sentencias si usamos ||
            // Tipos de comparacion:  mayor o igual que <>  igual ==  diferente que !=

            //true or false

            if (args[0] == nombre) 
            {

                Console.WriteLine($"Hola {args[0]}  {args[1]}!");

            }
            else
            {
                Console.WriteLine("intruso detectado");
            }
        }
    }
}

