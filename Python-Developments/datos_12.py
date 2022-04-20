'''
Una panadería vende barras de pan a 3.49€ cada una. El pan que no es el día tiene un descuento del 60%. Escribir un 
programa que comience leyendo el número de barras vendidas que no son del día. Después el programa debe mostrar el 
precio habitual de una barra de pan, el descuento que se le hace por no ser fresca y el coste final total.

'''
#Parte 1 - Presentación del programa.
print('Este programa cálcula descuento del 60% para el pan de ayer')
print('')
#Parte 2 - Solicitud de datos.
DESCUENTO = 0.6
PRECIO_PAN = 3.49

compra = float(input('Usuario: Por favor dime cuantos panes vas a comprar: '))
#Parte 3 - Procesamiento de la información

#Parte 4 - Entrega de resultados.
print(f'Usuario: Compraste: {compra :.0f} panes, valor a pagar de la compra es: ${compra * PRECIO_PAN :.2f}, valor a pagar aplicando descuento 60% por ser pan de ayer: ${(compra * PRECIO_PAN) * DESCUENTO :.2f}')
print('')
input('Presiona enter para salir...')