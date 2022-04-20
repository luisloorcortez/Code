''' 
Escribir un programa que pida al usuario dos números enteros y muestre por pantalla la <n> entre <m> da un cociente <c> y 
un resto <r> donde <n> y <m> son los números introducidos por el usuario, y <c> y <r> son el cociente y el resto de la 
división entera respectivamente.

'''
#Parte 1 - presentación del programa
print('Este programa es una calcúladora que realiza una división con dos números ingresados por el usuario')

#Parte 2 - Solicitar información
numero1 = int(input('Por favor ingresa el primer número: '))
numero2 = int(input('Por favor ingresa el segundo número: '))

#Parte 3 - Procesamiento de la información
cociente =  numero1 / numero2
resto = numero1 % numero2

#Parte 4 - Presentación de resultado

print(f'Usuario: La división entre {numero1} y {numero2} dio como resultado: {cociente} y como residuo: {resto}')

input('Presione una tecla para continuar...')