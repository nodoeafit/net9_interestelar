using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar) {
            Console.Clear();
            Console.WriteLine("Calculadora Avanzada por consola (.NET 9)");
            Console.WriteLine("=========================================");

            Console.Write("Introduce el primer numero:");
            if (!double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.WriteLine("Entrada invalida, Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.Write("Introduce el segundo numero:");
            double numero2 = 0;
            string inputNumero2 = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(inputNumero2) && !double.TryParse(inputNumero2, out numero2))
            {
                Console.WriteLine("Entrada invalida, Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }


            Console.WriteLine("Selecciona una operacion:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Raiz Cuadrada");
            Console.WriteLine("6. Elevar un numero al cuadrado");
            Console.WriteLine("7. Elevar a un numero");
            Console.WriteLine("8. Salir");
            Console.Write("Tu eleccion: ");

            string operacion = Console.ReadLine() ?? "";
            double resultado;

            switch (operacion)
            {
                case "1": // sumar
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "2": // resta
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "3": // multiplicacion
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                case "4": // division
                    if(numero2 == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir por cero");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    break;
                case "5": // raiz cuadrada
                    if(numero1 < 0)
                    {
                        Console.WriteLine("Error:  No se puede calcular la raiz de un numero negativo.");
                    } else
                    {
                        resultado = Math.Sqrt(numero1);
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    break;
                case "8":
                    continuar = false;
                    Console.WriteLine("Gracias por usar la calculadora.");
                    break;
                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}