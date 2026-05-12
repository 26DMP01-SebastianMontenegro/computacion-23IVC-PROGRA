using System;

class Act2_Lecc11_Inciso1
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 11 - ACTIVIDAD 2 - INCISO 1");
        Console.WriteLine("       PARES HASTA UN LIMITE - DO WHILE");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un limite entre 2 y 1000: ");
        int limite = int.Parse(Console.ReadLine());
        int numero = 2;
        int paso = 1;

        if (limite >= 2 && limite <= 1000)
        {
            do
            {
                Console.WriteLine("Progreso del ciclo: par " + paso);
                Console.WriteLine(numero);
                numero = numero + 2;
                paso = paso + 1;
            }
            while (numero <= limite);
        }
        else
        {
            Console.WriteLine("El limite debe estar entre 2 y 1000.");
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
