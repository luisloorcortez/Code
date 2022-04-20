'''
Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla la cuenta atrás desde ese número 
hasta cero separados por comas.

'''
#Parte 1 - Presentación del programa
print('Este número mostrará hasta 0 la cuenta atras desde el número ingresado')
print('')

#Parte 2 - Solicitus de información al usuario
numero = int(input('Usuario: Ingresa un número: '))
print('')

#Parte 3 - Procesamiento de la información
if numero < 0:
    print('El número ingresado no es positivo')
if numero % 1 != 0:
    print ('El número ingresado no es entero')
else: 
    for i in range(numero, -1, -1):
        print(i, end=(', '))

print('')
input('Presiona enter para terminar...')