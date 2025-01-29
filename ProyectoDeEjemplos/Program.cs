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

            //Numéricos
            int num = 123; // 123, 0, -2, 2000000
            short num2 = 123; // 123
            byte num3 = 123; // 123
            long num4 = 123; // 123, 2000000

            float num5 = 12.3f; // 12.3
            double num6 = 12.3; // 0.123e2
            num6 = 123.56; // 0.12356e3
            num6 = 0.00034; // 0.34e-3
            num6 = 34.7f;
            num6 = 45; // Z < R
            num5 = num;

            //Texto
            char letra;
            letra = 'w';
            //letra = 'que';
            letra = '8';
            letra = '?';

            string txt;
            txt = "Pepe";
            txt = "Juan \"Pepe\" Perales";
            txt = "Pepe\nPerales";
            txt = "Pepe\tPerales";
            txt = "";
            Console.WriteLine(txt);

            //Logico
            bool casado; // Álgebra booleana, lógica propicisional
            casado = false;
            casado = true;

            // Arreglos
            // Unidimensionales
            string[] roperoMama;
            roperoMama= new string[4];
            roperoMama[2] = "Blusa";
            roperoMama[3] = "Zapatos";

            /*
             
             [     ] 0 
             [     ] 1 
             [Blusa] 2 
             [ zap ] 3 
             
             [][][Blusa][Zap]
              0 1 2 3

             */
            Console.WriteLine(roperoMama[2]);
            Console.WriteLine(args[2]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[0]);
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