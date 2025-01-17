using System;
using System.Collections.Generic;

namespace SegundaClase
{
    class Program
    {
        // Nivel de acceso publico: public
        public string SaludoPublico = "Hola desde un atributo publico";

        // Nivel de acceso privado: private
        private int numeroSecreto = 42;

        // Nivel de acceso protegido: protected
        protected string MensajeProtegido = "Mensaje protegido";

        // Nivel de acceso interno: internal
        internal string MensajeInterno = "Mensaje interno";

        // Nivel de acceso interno protegido: protected internal
        protected internal string MensajeProtegidoInterno = "Mensaje protegido interno";

        // Nivel acceso privado protegido: private protected
        private protected string MensagePrivadoProtegido = "Mensaje privado protegido";

        static void Main(string[] args)
        {
            // Instanciar clase
            Program program = new Program();

            // Uso de datos primitivos
            int numero = 10;
            float decimalCorto = 3.14f;
            double decimalLargo = 3.14159;
            bool esVerdadero = true;
            char letra = 'A';

            Console.WriteLine($"Numero: {numero}, Decimal Corto: {decimalCorto}, Decimal Largo: {decimalLargo}, Letra: {letra}, Bool: {esVerdadero}");


            // Uso de datos especiales
            string texto = "Hola mundo en .net";
            object cualquierDato = 42; // cualquier tipo de dato
            dynamic dinamico = "Texto dinamico"; // esto un texto aca 
            Console.WriteLine($"Dinamico: {dinamico}");
            dinamico = 100; // le asigne un numero es entero

            Console.WriteLine($"Texto: {texto}");
            Console.WriteLine($"Object: {cualquierDato}");
            Console.WriteLine($"Dinamico: {dinamico}");

            // Uso de datos complejos 
            //Enums
            DiasSemana diaSemana = DiasSemana.Jueves;

            Console.WriteLine($"Hoy es: {diaSemana}");

            // Colecciones 
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> lista = new List<string> { "A", "B", "C", "D" };
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                {1, "Uno" },
                {2, "Dos" }
            };

            Console.WriteLine("Array: " + string.Join(", ", numeros));
            Console.WriteLine("Lista: " + string.Join(", ", lista));
            Console.WriteLine("Diccionario: " + dic[1]);

            program.MostrarPublico();
            program.MostrarPrivado();
            program.MostrarMensajeProtegido();


            MiDelegado delegado = program.MostrarMensaje;

            delegado("Hola desde un delegado");

        }

        // Metodo publico 
        public void MostrarPublico()
        {
            Console.WriteLine(SaludoPublico);
        }

        private void MostrarPrivado()
        {
            Console.WriteLine($"numero secreto: {numeroSecreto}");
        }

        protected void MostrarMensajeProtegido()
        {
            Console.WriteLine(MensajeProtegido);
        }

        public delegate void MiDelegado(string mensaje);

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }

    public enum DiasSemana
    {
        Lunes, 
        Martes,
        Miercoles,
        Jueves,
        Viernes
    }
}