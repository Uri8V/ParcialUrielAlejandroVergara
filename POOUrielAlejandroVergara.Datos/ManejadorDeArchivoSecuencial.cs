using POOUrielAlejandroVergara.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOUrielAlejandroVergara.Datos
{
     public class ManejadorDeArchivoSecuencial
    {
        private static string archivo = "Archivo.txt";
        public static void GuardarEnArchivoSecuencial(List<Elipses> elipses)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                foreach (var elipse in elipses)
                {
                    //var linea = ConstruirLinea(elipses);
                    // escritor.WriteLine(linea);
                }
            }
        }

        public static List<Elipses> LeerArchivo()
        {
            List<Elipses> lista = new List<Elipses>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    if (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Elipses elipses = ConstruirElipse(linea);
                        lista.Add(elipses);
                    }
                }
            }
            return lista;
        }

        private static Elipses ConstruirElipse(string linea)
        {
            var campos = linea.Split('|');
            Elipses elipses = new Elipses()
            {
                SemiEjeMayor = int.Parse(campos[0]),
                SemiEjeMenor = int.Parse(campos[1]),
                //Trazo =campos[3]
            };
            return elipses;
        }

        //private static object ConstruirLinea(List<Elipses> elipses)
        //{
        //   //return $"{elipses.}|{eli}"
        //}
    }
}
