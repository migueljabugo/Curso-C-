

namespace RRHH
{
    class Perro :Animal
    {
        public Perro()
        {
            base.Raza = "Perro";
        }

        public override string ReproducirSoido()
        {
            return base.ReproducirSoido()+"Guau!!";
        }
    }
}
