'''
Escribir un programa que pregunte al usuario su edad y muestre por pantalla si es mayor de edad o no.

'''

#Parte 1 - Presentación del programa
print('Este programa le muestra al usuario su edad')
print('')


#Parte 2 - Solicitud de información
edad = int(input('Usuario: Por favor escribe tu edad: '))

#Parte 3 - Realizamos las operaciones y entregamos infofrmación
if edad < int(18):
    print('Usuario: Eres menor de edad')
else:
    print('Usuario: Eres mayor de edad')

print('')
input('Presiona una tecla para continuar...')
