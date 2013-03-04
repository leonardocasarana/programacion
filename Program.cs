using System;
using System.Collections.Generic;

namespace Tarea_1
{
    class Persona
    {
        public string Nombre;
        public string Telefono;
        public string Email;
        public string Domicilio;

        public Persona()
        {
        }

         public static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("Intoduce tu Nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu Telefono ");
            persona.Telefono = Console.ReadLine();

            Console.WriteLine("Introduce tu Email ");
            persona.Email = Console.ReadLine();

            Console.WriteLine("Introduce tu Domicilio ");
            persona.Domicilio = Console.ReadLine();
            Console.WriteLine("");

             Console.WriteLine("Nombre: "+ persona.Nombre);
            
             Console.WriteLine("Telefono: " + persona.Telefono);

             Console.WriteLine("Email: " + persona.Email);

             Console.WriteLine("Domicilio: " + persona.Domicilio);

             Console.ReadLine();

        }
    }
}
