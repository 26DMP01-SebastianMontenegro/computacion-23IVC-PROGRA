using System;

class Act4_Lecc09_Inciso1
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 09 - ACTIVIDAD 4 - INCISO 1");
        Console.WriteLine("       TABLA DE MULTIPLICAR - WHILE");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un numero para la tabla: ");
        int numero = int.Parse(Console.ReadLine());
        int contador = 1;
        int resultado;

        while (contador <= 10)
        {
            resultado = numero * contador;
            Console.WriteLine("Progreso del ciclo: multiplicacion " + contador + " de 10");
            Console.WriteLine(numero + " x " + contador + " = " + resultado);
            contador = contador + 1;
        }

        Console.WriteLine("Tabla terminada.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
