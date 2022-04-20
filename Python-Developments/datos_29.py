'''
Los alumnos de un curso se han dividido en dos grupos A y B de acuerdo al sexo y el nombre. El grupo A esta formado por las mujeres 
con un nombre anterior a la M y los hombres con un nombre posterior a la N y el grupo B por el resto. Escribir un programa que pregunte 
al usuario su nombre y sexo, y muestre por pantalla el grupo que le corresponde.

'''
#Condiciones para el desarrollo
'''
Solicitudes:
1 - El usuario debe ser mayor de edad. (a)
2 - El usuario debe tener ingresos >= 1000 mensauales.(a)

Funcionalidades del programa:
3 - El programa debe preguntar por pantalla la edad del usuario y la cantidad de dinero que gana mensualmente.(a)
3 - El programa debe mostrar por pantalla si el usuario debe trubutar o no.

'''

nombre = input("¿Cómo te llamas? ")
sexo = input("¿Cuál es tu sexo (M o H)?: ")
if sexo != 'H' and sexo != 'M':
    print('Solo acepto los caracteres H o M.')
else:
    if sexo == "M":
        if nombre.lower() < "m":
            group = "A"
        else:
            group = "B"

    else:
        if nombre.lower() > "n":
            group = "A"
        else:
            group = "B"

    print("Tu grupo es " + group)