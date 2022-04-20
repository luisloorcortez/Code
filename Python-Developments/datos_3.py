'''
Escribir un programa que pregunte el nombre del usuario en la consola y después de que el usuario lo introduzca muestre por 
pantalla la cadena ¡Hola <nombre>!, donde <nombre> es el nombre que el usuario haya introducido.
'''
#Declaramos una variable y la inicializamos rectamente con <input> y pedimos por consola 
#El dato para llenar <nombre>.
nombre = input('Usuario: Por favor ingresa tu nombre: ')

#Concatenamos la variable <nombre> con el string, iniciando con la letra <f> fuera de la
#comilla.
print(f'Hola {nombre}!')

#Este <input> nos mastine el programa corriendo. <ENTER> paras salir. 
input('Presione una tecla para continuar...')