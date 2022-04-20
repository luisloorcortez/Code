'''
Escribir un programa que pregunte al usuario por el número de horas trabajadas y el coste por hora. Después
debe mostrar por pantalla la paga que le corresponde.

'''
print('Este porgrama calculará el coste a pagar por hora')
horas= float(input('Ingresa tu numero de horas trabajadas: '))
dinero = float(input('Ingresa el dinero que ganas por hora trabajada: '))
CALCULO = horas * dinero
print(f'Tu dinero a recibir es: ${CALCULO :.2f}')
input('Presiona enter para salir...')