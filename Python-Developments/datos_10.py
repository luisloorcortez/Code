'''
Una juguetería tiene mucho éxito en dos de sus productos: payasos y muñecas. Suele hacer venta por correo y la empresa 
de logística les cobra por peso de cada paquete así que deben calcular el peso de los payasos y muñecas que saldrán en 
cada paquete a demanda. Cada payaso pesa 112 g y cada muñeca 75 g. Escribir un programa que lea el número de payasos y 
muñecas vendidos en el último pedido y calcule el peso total del paquete que será enviado.

'''

#Parte 1 - Presentación del programa
print('Este programa calcula el peso en kg de su paquete a enviar')

#Parte 2 - Solicitud de información
#Constantes
PESO_MUÑECA = 75
PESO_PAYASO = 112
MUÑECA = 1
PAYASO = 2
PRECIO_MUÑECA = 100
PRECIO_PAYASO = 120

#Módulos
import os

#Bandera
ciclo = True

while ciclo:


    #Acumuladores
    peso_acum_1 = 0
    peso_acum_2 = 0
    prod_acum_1 = 0
    prod_acum_2 = 0
    cost_acum_1 = 0
    cost_acum_2 = 0

    os.system('cls')
    while ciclo:

        while ciclo:
            os.system('cls')
            producto = int(input(f'''
            Por favor seleccione el producto:

            {MUÑECA}) Muñecas
            {PAYASO}) Payaso

            : '''))             
        
            #Parte 3 - Procesamos la información
            if producto == 1:
                peso_acum_1 = peso_acum_1 + PESO_MUÑECA
                prod_acum_1 = prod_acum_1 + MUÑECA
                cost_acum_1 = cost_acum_1 + PRECIO_MUÑECA

            elif producto == 2:
                peso_acum_2 = peso_acum_2 + PESO_PAYASO
                prod_acum_2 = prod_acum_2 + PAYASO
                cost_acum_2 = cost_acum_2 + PRECIO_PAYASO

            print('')
            control = input('Para agregar otro producto, presione enter, para salir presione 0: ')
            if control == '0':
                ciclo = False
            
        #Parte 4 - Entregamos los resultados
        print('')
        print(f'Usuario: Compró un total de: {prod_acum_1 + prod_acum_2} productos: {prod_acum_1} muñecas y {prod_acum_2} payasos.')
        print(f'El peso total de los paquetes a enviar es: {peso_acum_1 + peso_acum_1} kg')
        print(f'El total de dinero a pagar por los productos es: ${cost_acum_2 + cost_acum_1}')
            
    print('')
    ciclo = True
    control = input('Para crear una lista nueva, presione enter, para salir presione 0: ')
    if control == '0':
        ciclo = False
