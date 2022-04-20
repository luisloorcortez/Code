'''
Escribir un programa que pregunte al usuario una cantidad a invertir, el interés anual y el número de años, y muestre 
por pantalla el capital obtenido en la inversión.

'''
#Parte 1 - Presentación del programa
print('Este programa cálcula el capital que optendrá tu inversión')

#Parte 2 - Solicitud de unformación
cantidad = int(input('Por favor ingresa la cantidad de dinero que deseas invertir: $'))
interes = int(input('Por favor ingresa el interés anual: '))
años = int(input('Por favor ingresa el número de años que estrá invertdo tu dinero: '))

#Parte 3 - Realizar operaciones
calculo = (cantidad * (años + (interes / 100) ** años) - cantidad)

#Parte 4 - Entrega de resultados
print(f'Usuario: El valor obtendrá la inversión es: ${calculo :.1f}')
input('Presiona enter para salir...')