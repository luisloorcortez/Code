'''
Los teléfonos de una empresa tienen el siguiente formato prefijo - número - extension donde el prefijo es el código del 
país +34, y la extensión tiene dos dígitos (por ejemplo +34- 913724710 -56). Escribir un programa que pregunte por un número 
de teléfono con este formato y muestre por pantalla el número de teléfono sin el prefijo y la extensión.

'''
#Parte 1 - Presentación  del programa
print('Este programa limpia un número de teléfono')

#parte 2 - Solicitud de información

telefono = input("Introduce un número de teléfono con el formato +xx-xxxxxxxxx-xx: ")
print('El número de teléfono es ', telefono[2:-2])     #Esto corta los string en una palabra


#Parte 3 - Realizar las operaciones
#Parte 4 - Entrega de resultados