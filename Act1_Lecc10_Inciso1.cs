using System;

class Act1_Lecc10_Inciso1
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 10 - ACTIVIDAD 1 - INCISO 1");
        Console.WriteLine("        CUPONERA DE CORTE - FOR");
        Console.WriteLine("========================================");
        Console.WriteLine("Se registran 6 personas para elegir un ganador del corte gratis.");
        Console.WriteLine();

        Random aleatorio = new Random();
        int numeroGanador = aleatorio.Next(1, 7);
        string nombre;
        string ganador = "";

        for (int contador = 1; contador <= 6; contador++)
        {
            Console.WriteLine("Progreso del ciclo: participante " + contador + " de 6");
            Console.Write("Ingrese el nombre del participante " + contador + ": ");
            nombre = Console.ReadLine();

            if (contador == numeroGanador)
            {
                ganador = nombre;
            }

            Console.WriteLine("----------------------------------------");
        }

        Console.WriteLine("El numero ganador fue: " + numeroGanador);
        Console.WriteLine("La persona ganadora del corte gratis es: " + ganador);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
