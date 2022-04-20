'''
Escribir un programa que pregunte el nombre del usuario en la consola y un número entero e imprima por pantalla en 
líneas distintas el nombre del usuario tantas veces como el número introducido.

'''
#Parte 1 - presentación del programa.
print('Este programa crea una lista de las cadenas que le ingreses')

#Parte 2 - Solicitud de información

nombre = input('Como te llamás')
numero = input ('Introduce el número de enteros')
print((nombre + '\n') * int(numero))