using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void ImprimeHolaMundo() {
            Console.WriteLine("Hola Mundo");
        }

        static int Suma(int a, int b) {
            return a + b;
        }

        static int Suma(float a, float b) {
            return (int)(a + b);
        }

        static int Suma(String a, String b)
        {
            int x = int.Parse(a);
            int y = int.Parse(b);
            return x + y;
        }

        /**
         * Dado un numero entre 0 y 100 retorna un valor decimal entre 0 y 1
         */
        static float normalizaValor(int num)
        {
            if (num >= 0 && num <= 100)
            {
                return num / 100f;
            }
            return -1;
            
        }


        static void Main(string[] args)
        {
            /*System.Console.WriteLine("Escribe tu mensaje");
            String mensaje = Console.ReadLine();
            String respuesta="";
            switch (mensaje) {
                case "Adios":
                case "Hola":
                    respuesta = "Hola que tal";
                    break;
                default:
                    respuesta = "No te entiendo.";
                    break;
            }

            System.Console.WriteLine(respuesta);
            */


            //Ejercicio 3 - pag 30 
            /*
            while (true)
            {
                Console.WriteLine("Introduce el mensaje");
                String mensaje = Console.ReadLine();
                String respuesta = "";
                switch ( mensaje.ToLower())
                {
                    case "si":
                        respuesta = "Afirmativo";
                        break;
                    case "no":
                        respuesta = "Negaivo";
                        break;
                    default:
                        respuesta = "Desconocido";
                        break;
                }
                Console.WriteLine(respuesta);
            }
            */
            /* String[] nombres = new String[] {"Pedro", "Manu"};
             foreach (String nombre in nombres)
             {

             }*/

            /*int[] numeros = new int[] {1,5,6,8,4,8,-15,-62,-6,5,15,};
            int negativos = 0;
            foreach (int numero in numeros)
            {
                if (numero<0)
                {
                    negativos++;
                }
            }

            Console.WriteLine(negativos);
            Console.ReadLine();
            */


            //Ejercicio 5 - pagina 30
            /*int[] numeros = new int[]{ 12,56,3,78,99,5,7,-5,-8};
            Console.WriteLine("For normal");
            for (int i = 0; i < numeros.Length; i++)
            {
                if ( numeros[i] % 2 == 0 )
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Foreach");
            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
            */

            /*
            ImprimeHolaMundo();
            Console.WriteLine( Suma(4, 5));
            Console.WriteLine(Suma(4.4f, 5));
            */

            /* 
             * Console.WriteLine("Introduce un porcentaje: ");
             Console.WriteLine("El valor normalizado es: " + normalizaValor(int.Parse(Console.ReadLine())));
             */
            Persona persona = new Persona();



            Console.ReadLine();//Esta linea espera un valor por consola, asi hacemos que la consola no se cierre.
        }
    }
}
