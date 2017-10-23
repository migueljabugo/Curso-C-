using System;

public enum Sexo
{
    HOMBRE, MUJER
}

public class Persona
{
    private string nombre;
    private string apellidos;
    private DateTime fechaNacimiento;
    private Sexo sexo;


	public Persona(string nombre, string apellidos, DateTime fechaNacimiento, Sexo sexo)
	{
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.fechaNacimiento = fechaNacimiento;
        this.sexo = sexo;
	}

#region Getters and Setters

    public Sexo getSexo()
    {
        return this.sexo;
    }
    
    public void setSexo(Sexo sexo)
    {
        this.sexo = sexo;
    }
    

    public string getNombre() {
        return this.nombre;
    }

    public void setNombre(string nombre) {
        this.nombre = nombre;
    }

    public string getApellidos()
    {
        return this.apellidos;
    }

    public void setApellidos(string apellidos)
    {
        this.apellidos = apellidos;
    }

    public void setFechaNacimiento(int dia, int mes, int anno) {
        this.fechaNacimiento = new DateTime(anno, mes, dia);
    }

    public DateTime getFechaNacimiento()
    {
        return this.fechaNacimiento;
    }

    public int getEdad() {

    }

#endregion


}
