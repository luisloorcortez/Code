'''Este programa crea un juego dode debes adivinar el número secreto, compitiendo con la máquina'''

#Presentación del programa y solicitud de información.
#variables
import os
import random

#contadores

numero_secreto = random.randint(1, 100)                                                              #Aquí vamos a gerar un numero aleatorio
usuario_ingresado = -1 
Usuario_maquina = -1                                                                                 #Aquí vamos a contar los numeros ingresados por el usuario.

#Acumuladores que la máquina usará para generar numero a comparar y reajustar el rango.
inferior = 1
superior = 100

#Análisis del problema

#Datos para el usuario máquina
while Usuario_maquina != numero_secreto and usuario_ingresado != numero_secreto:                      #Ponemos las condiciones de evaluación para ambos usuarioas en el inicio del ciclo
    
    os.system('cls')                                                                                  #Esto hace limpieza de la pantalla antes de iniciar
    print('Máquina: ¿Cúal es el número secreto?: ')                                                   #Aqui actualizamos el contador del número ingresado por el usuario usuario
    #Empezamos con la generación aleatorio del numero que la máquiva a comparar.
    Usuario_maquina = random.randint(inferior, superior)
    print(f'La máquina selecionó el número: {Usuario_maquina}')

    if Usuario_maquina < numero_secreto:
        print(f'El número que ingresaste: {Usuario_maquina}, es menor al número secreto')
        inferior = inferior + 1                                                                        #Este acumulador nos ayuda a subir el rango inferir.
    elif Usuario_maquina > numero_secreto:
        print(f'El número que ingresaste: {Usuario_maquina}, es mayor al número secreto')
        superior = superior - 1                                                                        #Este acumulador nos ayuda a disminuir el rango inferir.
    else:
            print(f'La máquina ingresó el número secreto: {numero_secreto}. Ha ganado!')

#Datos para el usuaio humano
    if Usuario_maquina != numero_secreto :                                                              #Esto nos ayuda a cerrar el ciclo secuencial.
        usuario_ingresado = int(input('Usuario: ¿Cúal es el número secreto?: '))                        #Aqui actualizamos el contador del número ingresado por el usuario usuario.
        #Empezamos las evaluaciones de las respuestas dadas por el usuario, usaremos if       
        if usuario_ingresado < numero_secreto:                                                               
            print(f'El número que ingresaste: {usuario_ingresado}, es menor al número secreto')
            if usuario_ingresado > inferior:
                inferior = usuario_ingresado + 1
        elif usuario_ingresado > numero_secreto:
            print(f'El número que ingresaste: {usuario_ingresado}, es mayor al número secreto')
            if usuario_ingresado < superior:
                superior = usuario_ingresado - 1
        else:
            print(f'El usuario ingresó el número secreto: {numero_secreto} Ha ganado')
    input('Preione enter para continuar...')
