Algoritmo Act2_Lecc10_Inciso2
    Escribir "========================================"
    Escribir "   LECCION 10 - ACTIVIDAD 2 - INCISO 2"
    Escribir "       ENTEROS PARES - PARA"
    Escribir "========================================"

    Definir limite, inicio, fin, contador Como Entero
    Escribir "Ingrese el numero limite: " Sin Saltar
    Leer limite

    Si limite >= 2 Entonces
        inicio <- 2
        fin <- limite
    Sino
        inicio <- limite
        fin <- 2
    FinSi

    Para contador <- inicio Hasta fin Con Paso 1 Hacer
        Escribir "Progreso del ciclo: revisando ", contador

        Si contador MOD 2 = 0 Entonces
            Escribir contador, " es par."
        FinSi
    FinPara

    Escribir "Proceso terminado."
    Esperar Tecla
FinAlgoritmo
