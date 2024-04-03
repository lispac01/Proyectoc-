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

        WriteLine("Ingrese Nombre del musico");
        musico.nombre = ReadLine();
        
        WriteLine("Ingrese la edad del musico");
        musico.edad = int.Parse( ReadLine());

        WriteLine("Ingrese Instrumento que toca musico");
        musico.instrumento_toca = ReadLine();
        WriteLine($"Nombre:  {musico.nombre?.ToUpper()}  Edad {musico.edad} Instrumento Que Toca: {musico.instrumento_toca} ");


        WriteLine("objeto persona");


        WriteLine("Ingrese el nombre de la persona");
        persona.nombre = ReadLine();

        WriteLine("Ingrese la edad de la persona");
        persona.edad = int.Parse(ReadLine());

        WriteLine($"Nombre:  {persona.nombre?.ToUpper()}  Edad {persona.edad}");

        persona.Correr();
        
    }
}