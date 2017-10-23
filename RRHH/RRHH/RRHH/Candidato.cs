using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH
{
    class Candidato : Persona
    {
        private string puesto;
        private CV cv;
        private float valoracion;

        public Candidato() { }

        public Candidato(string nombre, string apellidos, int edad, Sexo sexo, string dni, string puesto, CV cv, float valoracion) : base(nombre, apellidos, edad, sexo, dni)
        {
            this.puesto = puesto;
            this.cv = cv;
            this.SetValoracion(valoracion);
        }

        public Candidato(string datos) : base(datos)
        {
            string[] datosSeparados = datos.Split(',');
            this.puesto = datosSeparados[5];
            cv = null;
            valoracion = 0.0f;
        }

        public string GetPuesto()
        {
            return this.puesto;
        }

        public void SetPuesto(string puesto)
        {
            this.puesto = puesto;
        }

        public CV GetCV() {
            return this.cv;
        }

        public void SetCV(CV cv)
        {
            this.cv = cv;
        }

        public float GetValoracion()
        {
            return this.valoracion;
        }
        
        public void SetValoracion(float valoracion)
        {
            if (valoracion >= 0.0 && valoracion <= 1.0)
            {
                this.valoracion = valoracion;
            }
            else { }
        }

        public override string ToString() {
            return  "*****************\n" +
                "*               *\n"+
                "*   Candidato   *\n" +
                "*               *\n" +
                "*****************\n" +
                base.ToString() + "\n" +
                "Puesto: " + this.GetPuesto() + "\n" +
                this.GetCV()+
                "Valoración: "+this.GetValoracion();
        }

        public override bool Equals(object obj)
        {
            if (obj is Candidato)
            {
                Candidato aux = (Candidato)obj;
                return (aux.DNI == this.DNI);
            }
            else { return false; }
        }

    }
}
