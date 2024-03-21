using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Persona
{

    public String? nombre;
    public int edad;


    public int Edad
    {
        get { return edad; }
        set { edad = value; }

    }


    public string? Name
    {
        get { return nombre; }
        set { nombre = value; }

    }

    public void Correr()
    {
       Console.WriteLine("Corriendo........");
    }

  

}