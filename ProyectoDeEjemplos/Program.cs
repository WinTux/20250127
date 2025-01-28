namespace ProgramaPrincipal
{
    
    internal class Programa
    {
        static string nombre = "Pepe";
        static void Main(string[] args)
        {
            int edad = 20;
            Console.WriteLine("Hello, World!");
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            OtroMain(null);
        }

        static void OtroMain(string[] args) {
            Console.WriteLine("Hola mundo, dice " + nombre);
            //Console.WriteLine("La edad es " + edad);
        }
    }

    public class EjemploClase { 
    
    }
}

namespace Auxiliares {
    namespace Desarrollo {
        public class OtraClase {
            
        }
    }
}