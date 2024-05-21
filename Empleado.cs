namespace empleadoNamespace;

enum Cargos
{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
}

public class Empleado
{
    private string nombre;
    private string apellido;
    public DateTime fechaNacimiento;
    public char estadoCivil;
    public DateTime fechaIngreso;
    public double salario;
    private Cargos cargo;
    public string Nombre {
        get => nombre;
    }
    public string Apellido {
        get => apellido;
    }
    public Empleado() {
        cargo = Cargos.Investigador;
    }
    public float Antiguedad() {
        return DateTime.Now.Year - fechaIngreso.Year + (DateTime.Now.Month - fechaIngreso.Month)/12;
    }
    public int Edad()
    {
        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        if (fechaNacimiento.Month > DateTime.Now.Month)
            edad--;
        return edad;
    }
}