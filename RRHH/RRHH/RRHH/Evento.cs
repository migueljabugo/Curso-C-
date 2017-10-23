using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH
{
    class Evento
    {
        private string nombre;
        private int tiempo;
        private string lugar;

        public Evento() { }

        public Evento(string nombre, int tiempo, string lugar)
        {
            this.nombre = nombre;
            this.SetTiempo(tiempo);
            this.lugar = lugar;
        }

        public Evento(string datos)
        {
            string[] arrayDatos = datos.Split(',');
            nombre = arrayDatos[0];
            SetTiempo(int.Parse(arrayDatos[1]));
            lugar = arrayDatos[2];
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetTiempo()
        {
            return this.tiempo;
        }

        public void SetTiempo(int tiempo)
        {
            if (tiempo>=0 && tiempo<=100)
            {
                this.tiempo = tiempo;
            }
            else { }
        }

        public string GetLugar()
        {
            return this.lugar;
        }
        
        public void SetLugar(string lugar)
        {
            this.lugar = lugar;
        }

        public override string ToString()
        {
            return "Nombre evento: "+this.GetNombre()+" | " +
                "Tiempo: "+this.GetTiempo()+" | " +
                "Lugar: "+this.GetLugar();
        }

        public override bool Equals(object obj)
        {
            if (obj is Evento)
            {
                Evento aux = (Evento)obj;
                return (this.nombre == aux.nombre && this.lugar == aux.lugar && this.tiempo == aux.tiempo);
            }
            else { return false; }
        }
    }
}
