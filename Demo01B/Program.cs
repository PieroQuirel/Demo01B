using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombres = "Piero Alessandro";
            persona.Apellidos = "Quiroz Coronel";

            persona.AsignarNombresCompletos();

            Console.WriteLine(persona.NombresCompletos);

            Persona persona1 = new Persona("Reyna", "Torrico");

            triangulo triangulo = new triangulo();
            triangulo.Altura = 4;
            triangulo.Base = 5;
            Console.WriteLine(triangulo.CalcularArea());

            Console.WriteLine("Hola Mundo");
            Console.Read();
        }
    }
}
