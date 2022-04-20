'''
Escribir un programa que pida al usuario una palabra y la muestre por pantalla cuantas veces la palabra fue moestrada, 
además que también muestre la palabra ingresada.

'''
#Parte 1 - presentación del programa
print('Este programa mostrará una palabra 10 veces')
print('')

#Parte 2 - dolicitud de información

palabra = input('Usuario: ingresa una palabra: ')

#Parte 3 - desarrollo y busqueda de la información

for i in range(1, 11):
    print(f'Es la vez número: {i} que muestro la palabra: {palabra}')

print('')
input('Presione una tecla para terminar')