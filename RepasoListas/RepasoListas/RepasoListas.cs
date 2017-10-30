using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoListas
{
    class RepasoListas
    {
        private static List<string> colores = new List<string>();
        private static List<string> coloresPermitidos = new List<string>() {
            "rojo",
            "amarillo",
            "gris",
            "azul" ,
            "marron",
            "rosa",
            "blanco",
            "añil",
            "oro",
            "plata",
            "naranja",
            "verde"
        };


        private static void ImprimeLista(List<string> lista)
        {
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }

        public static void CrearDatosDePrueba(int numValores)
        {
            List<string> coloresRandom = new List<string>();
            Random random = new Random();
            for (int i = 0; i < numValores; i++)
            {
                int numAleatorio = random.Next(0, coloresPermitidos.Count()-1);
                string colorElegido = coloresPermitidos[numAleatorio];
                //Console.WriteLine(colorElegido);
                coloresRandom.Add(colorElegido);
            }
            colores.AddRange(coloresRandom);
        }

        public static void EliminarTodosLosColoresPorNombre(string colorAEliminar)
        {
            colores.RemoveAll(x => x == colorAEliminar);
        }

        public static void ContarNumeroDeCadaColor()
        {
            Dictionary<string, int> coincidencias = new Dictionary<string, int>();
            foreach (string color in colores)
            {
                if (coincidencias.ContainsKey(color))
                {
                    coincidencias[color]++;
                }
                else
                {
                    coincidencias.Add(color, 1);
                }
            }

            foreach (string color in coincidencias.Keys)
            {
                Console.Write(string.Format("{0} => {1}\n", color, coincidencias[color]));
            }

        }

        public static void RealizarTest()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Write("Introduce un comando: ");
                string frase = Console.ReadLine();
                frase = frase.ToLower();
                string[] splitted = frase.Split(' ');
                string comando = splitted[0];
                string valor="";
                if (splitted.Length > 1)
                {
                    valor = splitted[1];
                }
                switch (comando)
                {
                    case "add":
                        if (coloresPermitidos.Contains(valor))
                        {
                            //if (!colores.Contains(valor))
                            //{
                            //    colores.Add(valor);
                            //}
                            //else
                            //{
                            //    Console.WriteLine("El color ya existe en la lista.");
                            //}
                            
                        }
                        else { Console.WriteLine("Color no permitido."); }
                        break;
                    case "remove":
                        if (colores.Contains(valor))
                        {
                            colores.Remove(valor);
                        }
                        else
                        {
                            Console.WriteLine("El color no existe en la lista.");
                        }
                        
                        break;
                    case "exit":
                        exit = true;
                        break;
                    case "generate":
                        CrearDatosDePrueba(int.Parse(valor));
                        break;
                    case "print":
                        ImprimeLista(colores);
                        break;
                    case "removeall":
                        EliminarTodosLosColoresPorNombre(valor);
                        break;
                    case "countcolor":
                        ContarNumeroDeCadaColor();
                        break;
                    default:
                        break;
                }



                
            }
            

        }
    }
}
