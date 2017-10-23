using System;

public enum Sexo
{
    DESCONOCIDO, HOMBRE, MUJER
}

public class Persona
{
    private string nombre;
    private string apellidos;
    private int edad;
    private Sexo sexo;

    public Persona() { }

	public Persona(string nombre, string apellidos, int edad, Sexo sexo)
	{
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.edad = edad;
        this.sexo = sexo;
	}

    public Persona(string nombre, string apellidos, string edad, Sexo sexo)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.edad = int.Parse(edad);
        this.sexo = sexo;
    }

    #region Getters and Setters

    public Sexo GetSexo()
    {
        return this.sexo;
    }
    
    public void SetSexo(Sexo sexo)
    {
        this.sexo = sexo;
    }
    

    public string GetNombre() {
        return this.nombre;
    }

    public void SetNombre(string nombre) {
        this.nombre = nombre;
    }

    public string GetApellidos()
    {
        return this.apellidos;
    }

    public void SetApellidos(string apellidos)
    {
        this.apellidos = apellidos;
    }

    public int GetEdad()
    {
        return this.edad;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public string GetNombreCompleto()
    {
        return this.nombre + " " + this.apellidos;
    }

    public override string ToString() {
        return "Nombre: " + this.nombre + "\n" +
                "Apellidos: " + this.apellidos + "\n" +
                "Edad: " + this.edad + "\n" +
                "Sexo: " + this.sexo;
    }
    
    

#endregion


}
