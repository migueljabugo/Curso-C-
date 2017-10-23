using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH
{
    class CV
    {
        private Evento[] estudios;
        private Evento[] experiencias;
        private Candidato candidato;

        public CV() { }

        public CV(Evento[] estudios, Evento[] experiencias, Candidato candidato)
        {
            this.estudios = estudios;
            this.experiencias = experiencias;
            this.candidato = candidato;
        }

        public CV(string datos)
        {
            
        }

        public Evento[] GetEstudios()
        {
            return estudios;
        }

        public void SetEstudios(Evento[] estudios)
        {
            this.estudios = estudios;
        }

        public Evento[] GetExperiencias()
        {
            return this.experiencias;
        }

        public void SetExperiencias(Evento[] experiencias)
        {
            this.experiencias = experiencias;
        }

        public Candidato GetCandidato()
        {
            return this.candidato;
        }

        public override string ToString()
        {
            string s = 
                "\n******************\n" +
                "*                *\n" +
                "*   Curriculum   *\n" +
                "*                *\n" +
                "******************\n" +
                "=>Estudios: \n";
            foreach (Evento estudio in estudios)
            {
                s += estudio.ToString() + "\n";
            }
            s += "\n=>Experiencias: \n";
            foreach (Evento experiencia in experiencias)
            {
                s += experiencia.ToString() + "\n";
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            if (obj is CV)
            {
                CV aux = (CV)obj;
                return (this.candidato == aux.candidato && this.estudios == aux.estudios && this.experiencias == aux.experiencias);
            }
            else { return false; }
        }
    }
}
