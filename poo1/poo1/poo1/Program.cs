using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pepe", "Sanchez Perez", 20, Sexo.HOMBRE);
            Persona persona2 = new Persona("Pepito", "Perez", "15", Sexo.HOMBRE);
            Persona persona3 = new Persona();
/*
            Console.WriteLine(persona1);
            Console.WriteLine();
            persona1.SetEdad(35);
            persona1.SetNombre("Juan");
            Console.WriteLine(persona1);
            Console.WriteLine();
            Console.WriteLine(persona1.GetNombreCompleto());
            Console.WriteLine();
            Console.WriteLine(persona2);

            Console.WriteLine();
            Console.WriteLine(persona3);
            */
            Ciudadano ciudadano = new Ciudadano("55486285K");
            Console.WriteLine();
            Console.WriteLine(ciudadano);

            Console.ReadLine();
        }
    }
}
