internal class Empleado
{
    private string nombre;
    private int numeroEmpleado;
    private decimal salario;
    private bool activo;

    public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo)
    {
        this.nombre = nombre;
        this.numeroEmpleado = numeroEmpleado;
        this.salario = salario;
        this.activo = activo;
    }

    public void MostrarDetalles()
    {
        string estado = (activo) ? "Activo" : "Inactivo";
        Console.WriteLine($"Nombre: {nombre}, Número de empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");
    }

    public int ObtenerNumeroEmpleado()
    {
        return this.numeroEmpleado;
    }

    public void CambiarEstado(int nuevoEstado)
    {
        if (nuevoEstado == 1)
        {
            activo = true;
            Console.WriteLine("Empleado activado");
        }
        else if (nuevoEstado == 0)
        {
            activo = false;
            Console.WriteLine("Empleado desactivado");
        }
        else
        {
            Console.WriteLine("ERROR: Estado inválido");
        }
    }

    public void AumentoSalario(double porcentaje)
    {
        decimal aumento = salario * Convert.ToDecimal(0.15);
        salario += aumento;
        Console.WriteLine($"Salario aumentado en un {porcentaje}%");
        Console.WriteLine($"Nuevo salario para {nombre}: {salario:C}");
    }
}