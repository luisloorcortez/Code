'''
Escribir un programa que pregunte el nombre completo del usuario en la consola y después muestre por pantalla el nombre completo 
del usuario tres veces, una con todas las letras minúsculas, otra con todas las letras mayúsculas y otra solo con la primera letra 
del nombre y de los apellidos en mayúscula. El usuario puede introducir su nombre combinando mayúsculas y minúsculas como quiera.

'''
#Parte 1 - Presentación deñ programa
print ('Este programa mostrará su nombre por pantalla de diferentes maneras')

#Parte 2 - Solcitud de datos
#modulo
import os

#Bandera
ciclo = True

while ciclo:
#Parte 3 - Presentamos la información por pantalla
    os.system('clear')
    nombre  = input('Usuario: Escribe tu nombre: ')
    
    print('')
    print((nombre.lower() + '\n') * 3)                   #Esto muesstra el string de la variable en minúscula
    print((nombre.upper() + '\n') * 3)                   #Esto muesstra el string de la variable en mayúscula
    print((nombre.title() + '\n') * 3)                   #Esto muesstra el string de la variable en como oración

    print('')
    control = input('Preciona enter para ingresar otro número, 0 para salir: ')
    if control == '0' :
        ciclo = False

os.system('clear')