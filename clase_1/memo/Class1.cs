using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticaDos
{
    class Memoria
    {
        public List<MemoriaData> db = new List<MemoriaData>();
        public Memoria()
        {
            db = new List<MemoriaData>();
        }
        public void LeerMemoria()
        {
            ConsoleColor currentColor = Console.BackgroundColor;
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            
            int i = 0; 
            foreach (var item in dbObject)
            {
               
                MemoriaData memoriaData = new MemoriaData(item.Key.ToString(), item.Value["operacion"].ToString(), item.Value["resultado"].ToString());
                this.db.Add(memoriaData);
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.resultado.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }
        public int GetMemoriaData(String key)
        {
            int index = int.Parse(key);
          
            MemoriaData data = db[index];
            
            return data.resultado;
        }

        internal void multidimencional()
        {
            throw new NotImplementedException();
        }

        public void GuardarMemoria(MemoriaData data)
        {
            db.Add(data);
            int i = 0;
            db.ForEach((MemoriaData memoriaData) =>
            {
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} - {1}", memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.ResetColor();
                Console.WriteLine("Operación: {0}", memoriaData.operacion);
                Console.WriteLine("Resultado: {0}", memoriaData.resultado.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------- \n");
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            });
            string json = JsonConvert.SerializeObject(db.ToArray(), Formatting.Indented);
            string archivoDB = "../../../db.json";
            File.WriteAllText(archivoDB, json);
        }
        public void arreglo()
        {
            string[] Colores = { "Rojo", "Blanco", "Morado" };
            
            Array.Reverse(Colores);
            Array.ForEach(Colores, (item) => {
                Console.WriteLine(item);
            });
            String color = Array.Find(Colores, (item) => {
                return item.Length > 4;
            });
            Console.WriteLine(color);
            Console.WriteLine("Accede tus colores y separalos con comas(,):");
            String colorUser = Console.ReadLine();
            string[] newColors = colorUser.Split(' ');
            Console.WriteLine(newColors);
        }
       

        static void Main(String[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Arreglo Sencillo");
                string[] sencillo = { "Rojo", "Blanco", "Morado" };
                Console.WriteLine("[{0}]", string.Join(", ", sencillo));
                Console.WriteLine("Arreglo Dos Dimensiones");
                int[,] dosDimensiones = new int[5, 5];

                for (int i = 0; i < dosDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < dosDimensiones.GetLength(1); j++)
                    {
                        dosDimensiones[i, j] = i + j;
                        Console.WriteLine("{0},{1}={2}", i, j, dosDimensiones[i, j]);
                    }
                }
                Console.WriteLine("Arreglo Tres Dimensiones");
                int[,,] tresDimensiones = new int[5, 5, 5];
                for (int i = 0; i < tresDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < tresDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < tresDimensiones.GetLength(2); k++)
                        {
                            tresDimensiones[i, j, k] = i + j + k;
                            Console.WriteLine("{0},{1},{2}={3}", i, j, k, tresDimensiones[i, j, k]);
                        }
                    }
                }
                Console.WriteLine("Arreglo 4 Dimensiones");
                int[,,,] cuatroDimensiones = new int[5, 5, 5, 5];
                for (int i = 0; i < cuatroDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < cuatroDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < cuatroDimensiones.GetLength(2); k++)
                        {
                            for (int l = 0; l < cuatroDimensiones.GetLength(3); l++)
                            {
                                cuatroDimensiones[i, j, k, l] = i + j + k + l;
                                Console.WriteLine("{0},{1},{2},{3}={4}", i, j, k, l, cuatroDimensiones[i, j, k, l]);
                            }
                        }
                    }
                }
                string exit = Console.ReadLine();
                if (exit == "y")
                {
                    salir = true;
                }
            }
        }
    }
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(String date, String operation, String result)
        {
            fecha = DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }
    }


}