'''
Imagina que acabas de abrir una nueva cuenta de ahorros que te ofrece el 4% de interés al año. Estos ahorros 
debido a intereses, que no se cobran hasta finales de año, se te añaden al balance final de tu cuenta de ahorros. 
Escribir un programa que comience leyendo la cantidad de dinero depositada en la cuenta de ahorros, introducida 
por el usuario. Después el programa debe calcular y mostrar por pantalla la cantidad de ahorros tras el primer, 
segundo y tercer años. Redondear cada cantidad a dos decimales.

'''
#Parte 1 - En esta parte realizamos la presentación del programa.
print('Este programa le mostrará la cantidad de dinero en su cuenta de banco, inluido los intereses anuales')
print('')

#Parte 2 - En esta parate realizamos la solicitud de información.
DINERO_EXISTENTE = 1500
#DINERO_FUTURO = DINERO_EXISTENTE
INTERES_ANUAL= 0.04

#Bandera del bucle

ciclo = True

#Módulos
import os


while ciclo:    

    os.system('cls')
    print('')
    dinero_ingresado = float(input('Ingresa la cantidad de dinero a depositar: $'))
    DINERO_EXISTENTE = DINERO_EXISTENTE + dinero_ingresado

    #Parte 3 - En esta parte relizamos el procesado de la información.
    DINERO_FUTURO = DINERO_EXISTENTE

    año_1 = DINERO_FUTURO * INTERES_ANUAL
    DINERO_FUTURO = DINERO_FUTURO + año_1

    año_2 = DINERO_FUTURO * INTERES_ANUAL
    DINERO_FUTURO = DINERO_FUTURO + año_1

    año_3 = DINERO_FUTURO * INTERES_ANUAL
    DINERO_FUTURO = DINERO_FUTURO + año_1
    
    #Parte 4 - En este parte realizamos la entrega de resultados.
    print('')
    print(f'Usuario: Tus intereses ganados son: año 1: ${año_1 :.2f}, año 2: ${año_2 :.2f}, año 3: ${año_3 :.2f}')
    print(f'Usuario: El total de didero actual en tu cuenta es: ${DINERO_EXISTENTE :.2f}')
    print(f'Usuario: El total de dinero de tu cuenta en tres años será: ${DINERO_FUTURO :.2f}')

    print('')
    control = input('Presiona enter para ingresar otra cantida o 0 para salir: ')
    if control == '0':
        ciclo = False
    

