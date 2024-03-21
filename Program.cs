using Proyectoc;

class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        Deportista deportista = new Deportista();

        deportista.Correr();

        Console.WriteLine("Ingrese el nombre de la persona");
        persona.nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad de la persona");
        persona.edad = int.Parse(Console.ReadLine());

        Console.WriteLine($"Nombre:  {persona.nombre?.ToUpper()}  Edad {persona.edad}");

        persona.Correr();
        
    }
}