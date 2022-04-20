'''
La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes. Los ingredientes para cada tipo de pizza 
aparecen a continuación.

Ingredientes vegetarianos: Pimiento y tofu.
Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.

Escribir un programa que pregunte al usuario si quiere una pizza vegetariana o no, y en función de su respuesta le muestre un menú 
con los ingredientes disponibles para que elija. Solo se puede eligir un ingrediente además de la mozzarella y el tomate que están en 
todas la pizzas. Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.

'''
#Parte 1 - Presentación del programa:
print('Este programa le ayuda a seleccionar el tipo de pizza y sus ingredientes.')
print('')

#Parte 2 - Solicitud de información:
INGREDIENTES_BASE = 'mozzarella, tomate'
import os

os.system('cls')  

seleccion = int(input(f'''
Seleccione el tipo de pizza:

1) Vegetariana
2) No vegetariana

:  '''))

#Parte 3 - Desarrollo y entrega de información:

if seleccion == 1:

    print('')
    print(f'las pizza vegetariana trae como base {INGREDIENTES_BASE}.')

    ingrediente_extra = int(input(F'''   
    Debe seleccionar 1 ingrediente extra:

    1) Pimiento
    2) Tofu

    : '''))

    if ingrediente_extra == 1:
        print('')
        print(f'Usted selecció una pizza vegetariana con: {INGREDIENTES_BASE} y pimiento.')
    else:
        print('')
        print(f'Usted selecció una pizza vegetariana con: {INGREDIENTES_BASE} y tofu.')

else: 
    print('')
    print(f'las pizza no vegetariana trae como base {INGREDIENTES_BASE}.')

    ingrediente_extra = int(input(F'''   
    Debe seleccionar 1 ingrediente extra:

    1) Jamón
    2) Salmón

    : '''))

    if ingrediente_extra == 1:
        print('')
        print(f'Usted selecció una pizza no vegetariana con: {INGREDIENTES_BASE} y jamón.')
    else:
        print('')
        print(f'Usted selecció una pizza no vegetariana con: {INGREDIENTES_BASE} y salmón.')
