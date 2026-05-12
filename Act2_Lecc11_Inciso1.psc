Algoritmo Act2_Lecc11_Inciso1
    Escribir "========================================"
    Escribir "   LECCION 11 - ACTIVIDAD 2 - INCISO 1"
    Escribir "       PARES HASTA UN LIMITE - REPETIR"
    Escribir "========================================"

    Definir limite, numero, paso Como Entero
    Escribir "Ingrese un limite entre 2 y 1000: " Sin Saltar
    Leer limite
    numero <- 2
    paso <- 1

    Si limite >= 2 Y limite <= 1000 Entonces
        Repetir
            Escribir "Progreso del ciclo: par ", paso
            Escribir numero
            numero <- numero + 2
            paso <- paso + 1
        Hasta Que numero > limite
    Sino
        Escribir "El limite debe estar entre 2 y 1000."
    FinSi

    Esperar Tecla
FinAlgoritmo
