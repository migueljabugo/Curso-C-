public class Ciudadano : Persona
{
    private string dni;

    public Ciudadano(string nombre, string apellidos, int edad, Sexo sexo, string dni): base(nombre, apellidos, edad, sexo) {
        this.dni = dni;
    }

    public Ciudadano(string dni) : base() {
        this.dni = dni;
    }

    public string GetDNI() {
        return this.dni;
    }

    public override string ToString()
    {
        return base.ToString() + "\nDNI: " + dni;
    }
}
