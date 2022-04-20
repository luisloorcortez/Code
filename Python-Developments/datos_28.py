'''
Para tributar un determinado impuesto se debe ser mayor de 16 años y tener unos ingresos iguales o superiores a 1000 € mensuales. 
Escribir un programa que pregunte al usuario su edad y sus ingresos mensuales y muestre por pantalla si el usuario tiene que tributar 
o no.

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
#Parte 1 - Presentación del programa
print('Este programa le indicará al usuaraio si debe tributar o no')
print('')

#Parte 2 - Solcitud de información al usuario
EDAD = int(18)
SALARIO = int(1000)

edad_usuario = int(input('Usuario: Ingresa tu edad: '))
salario_usuario = int(input('Usuario: Ingresa tu salario: '))

if  edad_usuario < EDAD or salario_usuario < SALARIO:
    print('')
    print('El usuario no necesita tributar.')
    print('La condición que no cumple es usuario es la siguiente: ')
    if edad_usuario < EDAD and salario_usuario >= SALARIO:
        print('')
        print('La edad del usuario es menor a la requerida.')
        input('Presione una enter para salir...')

    elif edad_usuario >= EDAD and salario_usuario < SALARIO:
        print('')
        print('El salario del usuario es menor al requerido.')
        input('Presione una enter para salir...')
    
    elif edad_usuario < EDAD and salario_usuario < SALARIO:
        print('')
        print('El salario del usuario y su edad son menores a los queridos.')
        input('Presione una enter para salir...')
else:
    print('El usuario tiene que tributar.')
    print('')
    input('Presione una enter para salir...')
