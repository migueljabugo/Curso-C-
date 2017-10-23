using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH
{
    public class Persona
    {

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.edad = value;
                }
                else
                {
                    this.edad = 0;
                }
            }
        }

        private Sexo sexo;

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string dni;

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public Persona() { }

        public Persona(string nombre, string apellidos, int edad, Sexo sexo, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.Edad = edad;
            this.sexo = sexo;
            this.dni = dni;
        }

        public Persona(string datos)
        {
            string[] personaSplit = datos.Replace(" ", "").Split(',');

            this.nombre = personaSplit[0];
            this.apellidos = personaSplit[1];
            this.Edad = int.Parse(personaSplit[2]);
            this.sexo = (Sexo)int.Parse(personaSplit[3]);
            this.dni = personaSplit[4];
        }


        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "\n" +
                    "Apellidos: " + this.Apellidos + "\n" +
                    "Edad: " + this.Edad + "\n" +
                    "Sexo: " + this.Sexo + "\n" +
                    "DNI: " + this.DNI;
        }

        public override bool Equals(object obj)
        {
            if (obj is Persona)
            {
                Persona aux = (Persona)obj;
                return aux.DNI == this.DNI;
            }
            else
            {
                return false;
            }

        }
    }
}
