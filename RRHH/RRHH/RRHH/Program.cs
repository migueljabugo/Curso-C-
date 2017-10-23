using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Evento[] estudios = new Evento[2];
             estudios[0] = new Evento("FP DAM", 2, "Sevilla");
             estudios[1] = new Evento("FP", 2, "Sevilla");

             Evento[] experiencias = new Evento[2];
             experiencias[0] = new Evento("Empresa1", 1, "Sevilla");
             experiencias[1] = new Evento("Empresa2", 2, "Sevilla");
             Candidato candidato = new Candidato("Miguel Angel", "Gonzalez", 24, Sexo.HOMBRE, "54778565H", "Programador", null, 0.5f);
             CV cv = new CV(estudios, experiencias, candidato);
             candidato.SetCV(cv);

             Console.WriteLine(candidato.ToString());
             */

            /*Console.WriteLine("Nombre, Apellidos, edad, sexo(0, 1), dni");
            string personaBruto = Console.ReadLine();
            Persona persona = new Persona(personaBruto);
            Console.WriteLine(persona.ToString());
            */

            /* Candidato c1 = new Candidato("pepe, SAnchez, 15, 0, 00000000I, Becario");
             //Console.WriteLine(c1.ToString());
             Evento[] estudios = new Evento[2];
             estudios[0] = new Evento("FP DAM", 2, "Sevilla");
             estudios[1] = new Evento("FP", 2, "Sevilla");

             Evento[] experiencias = new Evento[2];
             experiencias[0] = new Evento("Empresa1", 1, "Sevilla");
             experiencias[1] = new Evento("Empresa2", 2, "Sevilla");

             CV cv = new CV(estudios, experiencias, c1);
             c1.SetCV(cv);
             Console.WriteLine(c1);
             */

            Animal animal = new Animal();
            animal.ReproducirSoido();
            Perro perro = new Perro();
            perro.ReproducirSoido();






            Console.ReadLine();
        }
    }
}
