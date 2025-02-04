using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Calculadora ====");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("❌ Opción no válida. Intente de nuevo.");
                Console.ReadKey();
                continue;
            }

            if (opcion == 5)
            {
                Console.WriteLine("👋 Saliendo del programa...");
                break;
            }

            Console.WriteLine($"🔹 Has seleccionado la opción {opcion}.");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
