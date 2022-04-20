'''
Escribir un programa que pregunte por consola por los productos de una cesta de la compra, separados por comas, y 
muestre por pantalla cada uno de los productos en una línea distinta.

'''

cesta = input('Introduce los productos de la cesta de la compra separados por comas: ')
print(cesta.replace(',', '\n'))

#Aquí estamos reeplazando la coma con un salto de linea


cesta = input('Introduce los productos de la cesta de la compra separados por comas: ')
print('\n'.join(cesta.split(',')))

#Aqui estamos usando la función para buscar la coma y dividir la cadena desde ahí