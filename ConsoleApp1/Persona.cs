    public enum Sexo
    {
        HOMBRE = 0,
        MUJER = 1
    }


    public class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private Sexo sexo;

        public Persona()
        {

        }

        public Persona(string nombre, string apellidos, int edad, Sexo sexo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.sexo = sexo;
        }




    }
