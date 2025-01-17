using System;

namespace PrimeraClase
{
    public static class Logger {
        public static void Log(string message){
             Console.WriteLine(message);
        }
    }

    public class MPrimeraClase {
        public int MiPrimeraVariable {get; set;}
    }

    class Program {
        static void Main(string[] args){
            Logger.Log("¿Como te llamas?");
            string nombre = Console.ReadLine() ?? "Invitado";
            Logger.Log($"Hola, {nombre}");
        }
    }
}


