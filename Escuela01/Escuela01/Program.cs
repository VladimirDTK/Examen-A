using System;
using System.Collections.Generic;

class Escuela
{
    public List<Maestro> maestros;
    public List<Alumno> alumnos;
    public List<Administrativo> administrativos;

    public Escuela()
    {
        maestros = new List<Maestro>();
        alumnos = new List<Alumno>();
        administrativos = new List<Administrativo>();

        // Agregar 20 maestros
        for (int i = 0; i < 20; i++)
        {
            maestros.Add(new Maestro(i));
        }

        // Agregar 50 alumnos
        for (int i = 0; i < 50; i++)
        {
            alumnos.Add(new Alumno(i));
        }

        // Agregar 15 administrativos
        for (int i = 0; i < 15; i++)
        {
            administrativos.Add(new Administrativo(i));
        }
    }
}

class Maestro
{
    public string matricula;
    public string nombre;
    public string apellidoPaterno;
    public string apellidoMaterno;
    public DateTime fechaNacimiento;
    public string curp;

    public Maestro(int index)
    {
        matricula = "1" + index.ToString().PadLeft(9, '0');
        nombre = "Maestro " + index;
        apellidoPaterno = "ApellidoPaterno " + index;
        apellidoMaterno = "ApellidoMaterno " + index;
        fechaNacimiento = new DateTime(1980, 1, 1).AddDays(index);
        curp = "CURP" + index.ToString().PadLeft(13, '0');
    }
}

class Alumno
{
    public string matricula;
    public string nombre;
    public string apellidoPaterno;
    public string apellidoMaterno;
    public DateTime fechaNacimiento;
    public string curp;

    public Alumno(int index)
    {
        matricula = "2" + index.ToString().PadLeft(9, '0');
        nombre = "Alumno " + index;
        apellidoPaterno = "ApellidoPaterno " + index;
        apellidoMaterno = "ApellidoMaterno " + index;
        fechaNacimiento = new DateTime(2000, 1, 1).AddDays(index);
        curp = "CURP" + index.ToString().PadLeft(13, '0');
    }
}

class Administrativo
{
    public string matricula;
    public string nombre;
    public string apellidoPaterno;
    public string apellidoMaterno;
    public DateTime fechaNacimiento;
    public string curp;

    public Administrativo(int index)
    {
        matricula = "3" + index.ToString().PadLeft(9, '0');
        nombre = "Administrativo " + index;
        apellidoPaterno = "ApellidoPaterno " + index;
        apellidoMaterno = "ApellidoMaterno " + index;
        fechaNacimiento = new DateTime(1990, 1, 1).AddDays(index);
        curp = "CURP" + index.ToString().PadLeft(13, '0');
    }
}

class Program
{
    static void Main(string[] args)
    {
        Escuela escuela = new Escuela();

        Console.WriteLine("¿Qué datos desea ver?");
        Console.WriteLine("1 - Maestros");
        Console.WriteLine("2 - Alumnos");
        Console.WriteLine("3 - Administrativos");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Maestros:");
                foreach (Maestro maestro in escuela.maestros)
                {
                    Console.WriteLine("Matrícula: " + maestro.matricula);
                    Console.WriteLine("Nombre: " + maestro.nombre);
                    Console.WriteLine("Apellido paterno: " + maestro.apellidoPaterno);
                    Console.WriteLine("Apellido materno: " + maestro.apellidoMaterno);
                    Console.WriteLine("Fecha de nacimiento: " + maestro.fechaNacimiento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("CURP: " + maestro.curp);
                    Console.WriteLine();
                }
                break;
            case 2:
                Console.WriteLine("Alumnos:");
                foreach (Alumno alumno in escuela.alumnos)
                {
                    Console.WriteLine("Matrícula: " + alumno.matricula);
                    Console.WriteLine("Nombre: " + alumno.nombre);
                    Console.WriteLine("Apellido paterno: " + alumno.apellidoPaterno);
                    Console.WriteLine("Apellido materno: " + alumno.apellidoMaterno);
                    Console.WriteLine("Fecha de nacimiento: " + alumno.fechaNacimiento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("CURP: " + alumno.curp);
                    Console.WriteLine();
                }
                break;

            case 3:
                Console.WriteLine("Administrativos:");
                foreach (Administrativo administrativo in escuela.administrativos)
                {
                    Console.WriteLine("Matrícula: " + administrativo.matricula);
                    Console.WriteLine("Nombre: " + administrativo.nombre);
                    Console.WriteLine("Apellido paterno: " + administrativo.apellidoPaterno);
                    Console.WriteLine("Apellido materno: " + administrativo.apellidoMaterno);
                    Console.WriteLine("Fecha de nacimiento: " + administrativo.fechaNacimiento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("CURP: " + administrativo.curp);
                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }

        Console.ReadKey();
    }
}
