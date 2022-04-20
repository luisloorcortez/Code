'''
Escribir un programa que pida al usuario que introduzca una frase en la consola y una vocal, y después muestre por pantalla 
la misma frase pero con la vocal introducida en mayúscula.

'''
#Parte 1 - Presentación del programa
#Parte 2 - Introducción de información al programa
 
frase = input("Introduce una frase: ")
vocal = input("Introduce una vocal en minúscula:  ")
print(frase.replace(vocal, vocal.upper()))    #Aquí toma la variable frase, usa la funcion replace, toma la variable vocal la vuelve mayúscula y la reeplaza en la frase.
