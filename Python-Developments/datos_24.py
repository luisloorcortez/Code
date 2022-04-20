'''
Escribir un programa que almacene la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña 
e imprima por pantalla si la contraseña introducida por el usuario coincide con la guardada en la variable sin tener en cuenta 
mayúsculas y minúsculas.

'''
#Parte 1 - Presentación del programa
print('Este programa le dirá si su contraseña de ingreso es correcta')
print('')

#Parte 2 - Solicitud de información
contraseña_ingresada = input('Usuario: Ingresa tu contraseña: ')

#Parte 3 - Realizar operaciones y procesar información
CONTRASEÑA = 'contraseña'

if contraseña_ingresada != CONTRASEÑA:
    print('Usuario, la contraseña no es correcta.')
else:
    print('Usuario: la contraseña es correcta. Bienvenido')

print('')
input('presiona enter para continuar...')
