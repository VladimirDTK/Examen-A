/* Instituto Tecnológico Superior de Cintalapa
 * Programación orientada a objetos
 * Lenin Coutiño Lázaro
 */
using System;
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("El animal está comiendo");
    }
}
public class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine("El perro está ladrando");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perro miPerro = new Perro();
        miPerro.Eat();
        miPerro.Ladrar();
    }
}