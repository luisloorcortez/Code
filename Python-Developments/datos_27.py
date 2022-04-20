'''
Escribir un programa que pida al usuario un número entero y muestre por pantalla si es par o impar.

'''
#Parte 1 - Presentación del programa
print('Este programa te deirá si un número es par o impar.')
print('')

#Parte 2 - Solicitud de información
numero = int(input('Usuario: Ingresa un número: '))

#Parte 3 - Proceso de información y entrega de datos

if numero % 2 == 0:
    print('Usuario: El número es par.')
    print('')
    input('Presione una  tecla para salir...')
else:
    print('Usuario: El número no es par.')
    print('')
    input('Presione una  tecla para salir...')