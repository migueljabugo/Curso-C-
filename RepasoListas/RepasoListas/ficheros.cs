using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RepasoListas
{
    class Ficheros
    {

        public static void RealizarTest()
        {
            //Console.WriteLine(LeerFicheroLineaALinea("../../Resources/prueba.txt"));
            //Console.WriteLine(LeerFichero("../../Resources/prueba.txt"));
            //CrearFichero("../../Resources/hola.txt", "Hola mundo!!!");
            ModificarFichero("../../Resources/hola.txt", "Adios mundo!!!");

        }

        public static string LeerFicheroLineaALinea(string ruta)
        {
            string res = "";
            try
            {
                StreamReader fichero = File.OpenText(ruta);
                string linea = "";
                while (linea != null)
                {
                    linea = fichero.ReadLine();
                    res += linea+"\n";
                }
                fichero.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el fichero.\n" + e);
            }
            return res;
        }

        public static string LeerFichero(string ruta)
        {
            string res = "";
            try
            {
                StreamReader fichero = File.OpenText(ruta);
                res = fichero.ReadToEnd()+"\n";
                fichero.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el fichero.\n" + e);
            }
            return res;
        }

        public static void CrearFichero(string ruta, string contenido)
        {
            try
            {
                StreamWriter fichero = File.CreateText(ruta);
                fichero.Write(contenido);
                fichero.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al crear el fichero.\n" + e);
            }
        }

        public static void ModificarFichero(string ruta, string contenido)
        {
            string contenidoOriginal = LeerFicheroLineaALinea(ruta);
            contenidoOriginal += contenido;
            CrearFichero(ruta, contenidoOriginal);
        }

        
    }
}
