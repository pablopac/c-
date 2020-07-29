using System;

namespace PPruebaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Pablo";
            string apellido = "alvarez";

            var persona = new { nombre, apellido };
            var prueba = new { casita = "Hola mundo", persona };
            Console.WriteLine(prueba);
        }
    }
}
