using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                listaPersonas.Add(new Persona("asdf" + i, "fdsa" + i, i, Sexo.HOMBRE, "4455" + i + "876H"));
            }

            //Console.WriteLine(string.Format("Hay {0} personas", listaPersonas.Count()));

            foreach (Persona persona in listaPersonas)
            {
                //Console.WriteLine(persona.ToString() + "\n");
            }


            //Diccionarios
            /*
            Persona p1 = new Persona("Rosa","Fernandez", 25,Sexo.MUJER, "0096D");
            Persona p2 = new Persona("Fernando", "Hermoso", 24, Sexo.HOMBRE, "0012K");
            Persona p3 = new Persona("Alvaro", "Perez", 19, Sexo.HOMBRE, "0045C");

            Dictionary<string, Persona> personasPorDNI = new Dictionary<string, Persona>();
            personasPorDNI.Add(p1.DNI, p1);
            personasPorDNI.Add(p2.DNI, p2);
            personasPorDNI.Add(p3.DNI, p3);


            foreach (string item in personasPorDNI.Keys)
            {
                Console.WriteLine(string.Format("---> Para el DNI ºn {0}: ", item));
                Console.WriteLine(personasPorDNI[item]+"\n");
            }
            */

            //fichero
            /* try
             {
                 StreamReader file = File.OpenText("../../resources/prueba.txt");
                 string linea = "";
                 while (linea != null)
                 {
                     linea = file.ReadLine();
                     Console.WriteLine(linea);
                 }
                 file.Close();
             }
             catch (Exception e) {
                 Console.WriteLine("Error al abrir el fichero" +e);
             }


             try { 
                 StreamWriter fichero = File.CreateText("../../resources/prueba.txt");
                 string frase = "Hola Mundo";
                 fichero.Write(frase);
                 fichero.Close();
             }
             catch(Exception e)
             {
                 Console.WriteLine("Error al escribir el fichero" + e);
             }
             */

            
            Console.ReadLine();
        }


        public static Persona GetPersonaPorDNI(List<Persona> personas, string dni)
        {
            Persona res = null;
            foreach (Persona persona in personas)
            {
                if (dni == persona.DNI)
                {
                    return persona;
                }
            }
            return res;
        }

        public static bool ExistePersonaPorDNI(List<Persona> personas, string dni)
        {
            bool res = false;
            foreach (Persona persona in personas)
            {
                if (dni == persona.DNI)
                {
                    return true;
                }
            }
            return res;
        }

        public static bool SoloHombres(List<Persona> personas)
        {
            bool res = true;
            foreach (Persona p in personas)
            {
                if (p.Sexo != Sexo.HOMBRE)
                {
                    return false;
                }
            }
            return res;
        }

        public static int NumeroPersonasMayoresDe(List<Persona> personas, int edad)
        {
            int res = 0;
            foreach (Persona p in personas)
            {
                if (p.Edad >= edad)
                {
                    res++;
                }
            }
            return res;
        }

        public static Persona PersonaMasMayor(List<Persona> personas)
        {
            Persona res = null;
            foreach (Persona p in personas)
            {
                if (res == null || p.Edad > res.Edad)
                {
                    res = p;
                }
            }
            return res;
        }



    }
}
