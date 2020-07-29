using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //helloWork();
            //variableType();
            //arimeticProducts();
            //archive();
            leerArchivo();
            anexarArchivo();
            leerArchivo();
        }

   

        public static void helloWork()
        {
            Console.WriteLine("Hola Mundo");
            Console.ReadKey();
        }

        public static void variableType()
        {
            int entero = 2134;
            float flotante = 435 ;
            byte variable = 230;
            double reeal = 2.58;
            bool boleano = true;
            char caracter = 'c';
            string cadena = "hola mundo";
            dynamic dinamico = "dinamico";

            Console.WriteLine("valor de entero es " + entero);
            Console.WriteLine("valor de flotante es " + flotante);
            Console.WriteLine("valor de byte es " + variable);
            Console.WriteLine("valor de real es " + reeal);
            Console.WriteLine("valor de variable es " + boleano);
            Console.WriteLine("valor de char es " + caracter);
            Console.WriteLine("valor de string es " + cadena);
            Console.WriteLine("valor de dynamic es " + dinamico);




            Console.ReadKey();

        }

        public static void arimeticProducts()
        {
            double num, pot, resultado;
            Console.WriteLine("digita numero");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digita numero");
            pot = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num, pot);

            Console.WriteLine("el resusltado es: " + resultado);

            Console.WriteLine("resultado es:" + Math.Sqrt(resultado));

            Console.ReadKey();

        }

        public static void archive()
        {
            TextWriter archivo;
            archivo = new StreamWriter("archivo.txt");

            Console.WriteLine("escriba el mensaje a guardar");
            String mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);
            archivo.Close();
            Console.Clear();
            Console.WriteLine("se guarda el archivo...");
            Console.ReadKey();




        }

        public static void leerArchivo()
        {
            TextReader leerArchivo;
            leerArchivo = new StreamReader("Archivo.txt");
            Console.WriteLine(leerArchivo.ReadToEnd());
            Console.ReadKey();
            leerArchivo.Close();

        }

        public static void anexarArchivo()
        {
            StreamWriter archivo =  File.AppendText("archivo.txt");
            Console.WriteLine("escriba el mensaje a guardar");
            String mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);
            archivo.Close();
            Console.WriteLine("guardado");

        }


    }
}
