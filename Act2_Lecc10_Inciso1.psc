Algoritmo Act2_Lecc10_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 10 - ACTIVIDAD 2 - INCISO 1"
    Escribir "    PRIMEROS 20 MULTIPLOS DE 4 - PARA"
    Escribir "========================================"

    Definir contador, resultado Como Entero

    Para contador <- 1 Hasta 20 Con Paso 1 Hacer
        resultado <- 4 * contador
        Escribir "Progreso del ciclo: multiplo ", contador, " de 20"
        Escribir "4 x ", contador, " = ", resultado
    FinPara

    Escribir "Proceso terminado."
    Esperar Tecla
FinAlgoritmo
