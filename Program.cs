using Proyectoc;
using static System.Console;

class Program
{
    static void Main()
    {
        Persona persona = new Persona();
        Deportista deportista = new Deportista();
        musico musico = new musico();
        
        WriteLine("objeto deportista");
        deportista.Correr();

        WriteLine("objeto musico");
        musico.IrConcierto();

        WriteLine("Ingrese el nombre de la persona");
        persona.nombre = ReadLine();

        WriteLine("Ingrese la edad de la persona");
        persona.edad = int.Parse(ReadLine());

        WriteLine($"Nombre:  {persona.nombre?.ToUpper()}  Edad {persona.edad}");

        persona.Correr();
        
    }
}