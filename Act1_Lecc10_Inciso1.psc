Algoritmo Act1_Lecc10_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 10 - ACTIVIDAD 1 - INCISO 1"
    Escribir "        CUPONERA DE CORTE - PARA"
    Escribir "========================================"
    Escribir "Se registran 6 personas para elegir un ganador del corte gratis."

    Definir contador, numeroGanador Como Entero
    Definir nombre, ganador Como Cadena
    numeroGanador <- Azar(6) + 1
    ganador <- ""

    Para contador <- 1 Hasta 6 Con Paso 1 Hacer
        Escribir "Progreso del ciclo: participante ", contador, " de 6"
        Escribir "Ingrese el nombre del participante ", contador, ": " Sin Saltar
        Leer nombre

        Si contador = numeroGanador Entonces
            ganador <- nombre
        FinSi

        Escribir "----------------------------------------"
    FinPara

    Escribir "El numero ganador fue: ", numeroGanador
    Escribir "La persona ganadora del corte gratis es: ", ganador
    Esperar Tecla
FinAlgoritmo
