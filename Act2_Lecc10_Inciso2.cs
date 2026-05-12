using System;

class Act2_Lecc10_Inciso2
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 10 - ACTIVIDAD 2 - INCISO 2");
        Console.WriteLine("       ENTEROS PARES - FOR");
        Console.WriteLine("========================================");

        Console.Write("Ingrese el numero limite: ");
        int limite = int.Parse(Console.ReadLine());
        int inicio;
        int fin;

        if (limite >= 2)
        {
            inicio = 2;
            fin = limite;
        }
        else
        {
            inicio = limite;
            fin = 2;
        }

        for (int contador = inicio; contador <= fin; contador++)
        {
            Console.WriteLine("Progreso del ciclo: revisando " + contador);

            if (contador % 2 == 0)
            {
                Console.WriteLine(contador + " es par.");
            }
        }

        Console.WriteLine("Proceso terminado.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
