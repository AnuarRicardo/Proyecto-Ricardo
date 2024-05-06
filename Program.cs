

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("App de gestión de empleados");
        List<Empleado> listaEmpleados = new List<Empleado>();
        listaEmpleados.Add(new Empleado("Juan", 101, 30000, true));
        listaEmpleados.Add(new Empleado("Maria", 102, 35000, true));
        listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false));

        foreach (var empleado in listaEmpleados)
        {
            empleado.MostrarDetalles();
        }

        int numeroEmpleadoCambiarEstado = 103;
        Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

        if (empleadoCambiarEstado != null)
        {
            empleadoCambiarEstado.CambiarEstado(1);
            empleadoCambiarEstado.MostrarDetalles();
            empleadoCambiarEstado.AumentoSalario(15); 
        }
        else
        {
            Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado");
        }
    }

    static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
    {
        foreach (var empleado in empleados)
        {
            if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
            {
                return empleado;
            }
        }
        return null;
    }
}
