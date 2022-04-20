'''Porcentaje de vida personajes videojuegos'''

import os                                                             #Llamos esta opción que limpia la pantalla

#Constante
MAGO = 1
GUERRERO = 2
SACERSOTIZA = 3
SALIR = 4

#Bandera nos dice cuando salir

continuar = True                                                      #Esto es un portero que mantendrá corriendo el bucle mientras sea posot
#Desarrollo del ejercicios y entrega de resultados
print('')
while continuar:
    os.system('cls')
    print(f'''
    Seecciona tu personaje 

    {MAGO} Mago
    {GUERRERO} Guerrero
    {SACERSOTIZA} Sacerdotiza
    {SALIR} Salir  
    
    ''')
    opcion = int(input('Selecciona tu personaje, o selecciona salir: '))

    if opcion == MAGO:
        
        print(f'''
        Ha seleccionado MAGO, sus habilidades son:

        Fuerza: 15
        Energía: 20
        Especial: 12
        
        ''')
        input('Presiona enter para continua....')
    elif opcion == GUERRERO:
    
        print(f'''
        Ha seleccionado GUERRERO, sus habilidades son:

        Fuerza: 25
        Energía: 18
        Especial: 10
         ''')
        input('Presiona enter para continua....')
    elif opcion == SACERSOTIZA:
        
        print(f'''
        Ha seleccionado SACERDOTIZA, sus habilidades son:

        Fuerza: 18
        Energía: 25
        Especial: 22
         ''')
        input('Presiona enter para continua....')
    elif opcion == SALIR:
        continuar = False
    
    else:
        print('Opción no valida. Seleccione una opción')
    
input()  