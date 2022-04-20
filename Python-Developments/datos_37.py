'''
Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla todos los números impares desde 1 hasta 
ese número separados por comas.

'''
#Parte 1 - Presentación del programa
print('Este programa muestra los números enteros positivos desde 1 hasta el ingresado')

#Parte 2 - Solicitar información al usuario
numero = int(input('Usuario: Ingresa un número: '))

#Parte 3 - Procesamiento y entrega de resultado

if numero <= 0:  
    print('El número ingresado no es positivo.')
elif numero % 1 != 0:
    print('El número ingresaado no es entero.')
else:
    print('')
    for i in range(1, (numero + 1) , 2):
        print( i, end=", ")
print('')
input('Presiona enter para terminar...')