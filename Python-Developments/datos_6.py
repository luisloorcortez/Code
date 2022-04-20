'''
Escribir un programa que lea un entero positivo, n , introducido por el usuario y después 
muestre en pantalla la suma de todos los enteros desde 1 hasta n. La suma de los n primeros enteros positivos 
puede ser calculada de la siguiente forma: /suma = n * (n + 1) / 2/

'''
numero = int(input('Por favor ingresa un número : ' ))
calculo = numero * (numero + 1) / 2
print(f'La suma de los primeros números enteros desde 1 hasta: {numero} es {calculo}')
input('Presione enter para continuar...')