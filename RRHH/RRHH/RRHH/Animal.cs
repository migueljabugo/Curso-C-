
namespace RRHH
{
    class Animal
    {
        private string raza;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public Animal() {
            this.raza = "Desconocida";
        }

        public virtual string ReproducirSoido()
        {
            return "Este es el sonido del animal:";
        }

    }
}
