'''
Escribir un programa que pida al usuario un número entero y muestre por pantalla un triángulo rectángulo como el de más abajo, 
de altura el número introducido.

'''
#Parte 1 - Presentación del programa
print('Este programa crea un triangulo usando ciclos')

#Parte 2 - Solicitud de información al usuario
numero = int(input("Introduce la altura del triángulo (entero positivo): "))
for i in range(numero):

    for j in range(i+1):
        print("*", end="")
    
    print("")


#Modo 2 de resolver el ejercicio
for i in range(numero):
   print("*"*(i+1))