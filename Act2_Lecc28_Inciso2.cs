using System;

class Act2_Lecc28_Inciso2
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 28 - ACTIVIDAD 2 - INCISO 2");
        Console.WriteLine("     PRUEBA DE BOLETOS EN LA FERIA");
        Console.WriteLine("========================================");
        Console.WriteLine("Adulto: $15 | Nino: $10");
        Console.WriteLine("Use este programa para que un companero lo pruebe.");
        Console.WriteLine("Digite 1 para adulto, 2 para nino y 0 para terminar.");
        Console.WriteLine();

        int opcion = 1;
        int contadorAdultos = 0;
        int contadorNinos = 0;
        int contadorBoletos = 0;
        int acumuladorDinero = 0;
        int paso = 1;

        while (opcion != 0)
        {
            Console.WriteLine("Progreso del ciclo: venta " + paso);
            Console.Write("Ingrese tipo de boleto: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                contadorAdultos = contadorAdultos + 1;
                contadorBoletos = contadorBoletos + 1;
                acumuladorDinero = acumuladorDinero + 15;
                Console.WriteLine("Boleto de adulto vendido.");
            }
            else
            {
                if (opcion == 2)
                {
                    contadorNinos = contadorNinos + 1;
                    contadorBoletos = contadorBoletos + 1;
                    acumuladorDinero = acumuladorDinero + 10;
                    Console.WriteLine("Boleto de nino vendido.");
                }
                else
                {
                    if (opcion != 0)
                    {
                        Console.WriteLine("Opcion incorrecta.");
                    }
                }
            }

            Console.WriteLine("Total de boletos vendidos: " + contadorBoletos);
            Console.WriteLine("Total de dinero cobrado: $" + acumuladorDinero);
            Console.WriteLine("----------------------------------------");
            paso = paso + 1;
        }

        Console.WriteLine("Resultado para comparar con el companero:");
        Console.WriteLine("Adultos: " + contadorAdultos);
        Console.WriteLine("Ninos: " + contadorNinos);
        Console.WriteLine("Boletos vendidos: " + contadorBoletos);
        Console.WriteLine("Dinero cobrado: $" + acumuladorDinero);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
