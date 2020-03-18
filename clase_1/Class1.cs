
using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace practicados
{
    class Memoria
    {
        public void Leermemoria()
        {
            string archivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            // Prueba de lectura de archivo db.json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            // Lectura de json iterable
            foreach ((var key, var item) in dbObject)
            {
                // Iteración individual de cada grupo de datos del objeto json.
                Console.WriteLine("Dato de Memoria: ");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item["operacion"].ToString(), (int)item["resultado"]);
                DateTime OP = Convert.ToDateTime(key);
                Console.WriteLine(key.ToString());
                Console.WriteLine(memoriaData.ToString());
                Console.WriteLine("\n");
            }
        }
    }

    class MemoriaData 
    {
        public DateTime fecha;
        public string operacion;
        public int resultado;

        public MemoriaData(DateTime date, string operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result;
        
        }
    }
}