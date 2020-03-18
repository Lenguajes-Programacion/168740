using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using PracticaDos;

namespace practicados
{




    public class Calculadora


    {
        static void Main(string[] args)


        {

            Console.Title = "calculadora";

            string resp = "";

            float R = 0;

            float valor1 = 0;

            float valor2 = 0;

            float valor3 = 0;
            Memoria memoria = new Memoria();


            do

            {





                Console.WriteLine("selecciona una operacion:");

                Console.WriteLine("Para sumar presiona +");

                Console.WriteLine("Para restar presiona -");

                Console.WriteLine("Para multiplicar presiona X");

                Console.WriteLine("Para dividir presiona /");

                Console.WriteLine("Para leer archivo JSON presiona m");


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

                        R = valor1 * valor2;

                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);

                        break;

                    case "/":

                        Console.WriteLine("El resultado es:");

                        R = valor1 / valor2;

                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);

                        break;

                    case "m":
                        Memoria memo = new Memoria();
                        memo.multidimencional();

                      
                        memoria.arreglo();

                        break;
                }


                Console.Write("¿Desea Continuar? s/n: ");

                resp = Console.ReadLine();

            }

            while (resp == "s" || resp == "s");


            do
            {

                if (resp == "si")
                {
                    Console.WriteLine("selecciona una operacion:");

                    Console.WriteLine("Para sumar presiona +");

                    Console.WriteLine("Para restar presiona -");

                    Console.WriteLine("Para multiplicar presiona X");

                    Console.WriteLine("Para dividir presiona /");

                    Console.Write("Tu eleccion es: ");

                    if (resp == "+")
                    {
                        Console.WriteLine("ingresa tu numero");
                        valor1 = R;

                        valor2 = float.Parse(Console.ReadLine());
                        R = R + valor2;
                        Console.WriteLine("El resultado es" + R);
                        Console.ReadLine();

                    }
                    if (resp == "-")
                    {
                        Console.WriteLine("ingresa tu numero");

                        valor2 = float.Parse(Console.ReadLine());
                        valor3 = R;
                        R = valor3 - valor2;
                        Console.WriteLine("El resultado es" + R);
                        Console.ReadLine();

                    }

                    if (resp == "*")
                    {
                        Console.WriteLine("ingresa tu numero");

                        valor2 = float.Parse(Console.ReadLine());
                        valor3 = R;
                        R = valor3 * valor2;
                        Console.WriteLine("El resultado es" + R);
                        Console.ReadLine();

                    }
                    if (resp == "/")
                    {
                        Console.WriteLine("ingresa tu numero");

                        valor2 = float.Parse(Console.ReadLine());
                        valor3 = R;
                        R = valor3 / valor2;
                        Console.WriteLine("El resultado es" + R);
                        Console.ReadLine();

                    }
                }
            }
            while (resp == "s" || resp == "s");
            Console.WriteLine("Continuar? Si / No");
            resp = Console.ReadLine();
        }

    }
}

