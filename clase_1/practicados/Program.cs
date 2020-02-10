using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace practicados
{
   



    class Calculadora

    {

        static void Main(string[] args)

        {

            Console.Title = "calculadora"; 

            string resp = "";

            do

            {

                float valor1 = 0; 

                float valor2 = 0; 

                float R = 0; 

 


                Console.WriteLine("selecciona una operacion:");

                Console.WriteLine("Para sumar presiona +");

                Console.WriteLine("Para restar presiona -");

                Console.WriteLine("Para multiplicar presiona X");

                Console.WriteLine("Para dividir presiona /");

                Console.Write("Tu eleccion es: "); 

                resp = Console.ReadLine();

                string eleccion = Convert.ToString(resp);

                Console.WriteLine("Ingresa tus dos numeros");

                Console.Write("Primer numero: ");

                valor1 = int.Parse(Console.ReadLine());

                Console.Write("Segundo numero: ");

                valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

 

                switch (eleccion)

                {

                    case "+":

                        Console.WriteLine("El resultado es:");

                        R = valor1 + valor2;

                        Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);

                        break;

                    case "-":

                        Console.WriteLine("El resultado es:");

                        R = valor1 - valor2;

                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);

                        break;

                    case "x":

                        Console.WriteLine("El resultado es:");

                        R = valor1* valor2;

                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);

                        break;

                    case "/":

                        Console.WriteLine("El resultado es:");
                        
                        R = valor1 / valor2;
                        
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        
                        break;
                        
                }


                Console.Write("¿Desea Continuar? s/n: "); 

                resp = Console.ReadLine();

            }

            while (resp == "s" || resp == "s");

        }

    }

}


