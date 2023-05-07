using System;
using System.Collections.Generic;

public class Escuela
{
    public List<Maestro> Maestros { get; set; }
    public List<Alumno> Alumnos { get; set; }
    public List<Administrativo> Administrativos { get; set; }

    public Escuela()
    {
        Maestros = new List<Maestro>();
        Alumnos = new List<Alumno>();
        Administrativos = new List<Administrativo>();

        // Generar datos aleatorios para nombres y apellidos
        string[] nombres = new string[] { "Juan", "Pedro", "María", "Ana", "José", "Luis", "Alejandro", "Fernando", "Carlos", "Miguel", "David", "Manuel", "Jorge", "Daniel", "Roberto", "Raúl", "Ricardo", "Emilio", "Gustavo", "Andrés" };
        string[] apellidos = new string[] { "García", "Hernández", "Martínez", "López", "González", "Pérez", "Rodríguez", "Sánchez", "Romero", "Fernández", "Díaz", "Cruz", "Álvarez", "Torres", "Ruiz", "Ramírez", "Flores", "Mendoza", "Vázquez", "Reyes" };

        // Agregar 20 maestros
        for (int i = 0; i < 20; i++)
        {
            string matricula = (i + 1).ToString().PadLeft(10, '0');
            string nombre = nombres[new Random().Next(nombres.Length)];
            string apellidoPaterno = apellidos[new Random().Next(apellidos.Length)];
            string apellidoMaterno = apellidos[new Random().Next(apellidos.Length)];
            DateTime fechaNacimiento = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 13), new Random().Next(1, 29));
            string curp = "XXXX" + fechaNacimiento.ToString("yyMMdd") + "XXX";

            Maestros.Add(new Maestro(matricula, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, curp));
        }

        // Agregar 50 alumnos
        for (int i = 0; i < 50; i++)
        {
            string matricula = (i + 1).ToString().PadLeft(10, '0');
            string nombre = nombres[new Random().Next(nombres.Length)];
            string apellidoPaterno = apellidos[new Random().Next(apellidos.Length)];
            string apellidoMaterno = apellidos[new Random().Next(apellidos.Length)];
            DateTime fechaNacimiento = new DateTime(new Random().Next(2000, 2010), new Random().Next(1, 13), new Random().Next(1, 29));
            string curp = "XXXX" + fechaNacimiento.ToString("yyMMdd") + "XXX";

            Alumnos.Add(new Alumno(matricula, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, curp));
        }

        // Agregar 15 administrativos
        for (int i = 0; i < 15; i++)
        {
            string matricula = (i + 1).ToString().PadLeft(10, '0');
            string nombre = nombres[new Random().Next(nombres.Length)];
            string apellidoPaterno = apellidos[new Random().Next(apellidos.Length)];
            string apellidoMaterno = apellidos[new Random().Next(apellidos.Length)];
            DateTime fechaNacimiento = new DateTime(new Random().Next(1970, 2000), new Random().Next(1, 13), new Random().Next(1, 29));
            string curp = "XXXX" + fechaNacimiento.ToString("yyMMdd") + "XXX";
            Administrativos.Add(new Administrativo(matricula, nombre, apellidoPaterno, apellidoMaterno, fechaNacimiento, curp));
        }
    }
}

public class Maestro
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string CURP { get; set; }
    public Maestro(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        FechaNacimiento = fechaNacimiento;
        CURP = curp;
    }
}

public class Alumno
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string CURP { get; set; }
    public Alumno(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        FechaNacimiento = fechaNacimiento;
        CURP = curp;
    }
}

public class Administrativo
{
    public string Matricula { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string CURP { get; set; }
    public Administrativo(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp)
    {
        Matricula = matricula;
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        FechaNacimiento = fechaNacimiento;
        CURP = curp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Escuela escuela = new Escuela(); Console.WriteLine("¿Qué datos desea ver?");
        Console.WriteLine("1. Maestros");
        Console.WriteLine("2. Alumnos");
        Console.WriteLine("3. Administrativos");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                foreach (Maestro maestro in escuela.Maestros)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", maestro.Matricula, maestro.Nombre, maestro.ApellidoPaterno, maestro.ApellidoMaterno, maestro.FechaNacimiento.ToShortDateString(), maestro.CURP);
                }
                break;
            case 2:
                foreach (Alumno alumno in escuela.Alumnos)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", alumno.Matricula, alumno.Nombre, alumno.ApellidoPaterno, alumno.ApellidoMaterno, alumno.FechaNacimiento.ToShortDateString(), alumno.CURP);
                }
                break;
            case 3:
                foreach (Administrativo administrativo in escuela.Administrativos)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}", administrativo.Matricula, administrativo.Nombre, administrativo.ApellidoPaterno, administrativo.ApellidoMaterno, administrativo.FechaNacimiento.ToShortDateString(), administrativo.CURP);
                }
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
        Console.ReadLine();
    }
}

