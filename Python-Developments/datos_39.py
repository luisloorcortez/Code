'''
Escribir un programa que pregunte al usuario una cantidad a invertir, 
el interés anual y el número de años, y muestre por 
pantalla el capital obtenido en la inversión cada año que dura la inversión.

'''
#Parte 1 - Presentación del programa
print('Este programa le mostrará cuanto ganará por año con su inversión')

#Parte 2 - Solicitusd e información al usuario
cantidad = int(input('Usuario: Ingrese la cantidad a invertir: '))
interes = int(input('Usuario: Ingrese el interés anual: '))
años = int(input('Usuario: Ingrese el número de años: '))

#Parte 3 - Prcesamiento y emtrega de resultados
print('')
for i in range(1, (años+1)):
    print(f'Usuario: El valor obtendrá la inversión en el año {i} es: $ {(cantidad * (i + (interes / 100) ** i) - cantidad) :.2f}')
print('')
input('Presiona enter para salir...')