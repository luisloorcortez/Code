'''
Escribir un programa para una empresa que tiene salas de juegos para todas las edades y quiere calcular de forma automática el precio 
que debe cobrar a sus clientes por entrar. El programa debe preguntar al usuario la edad del cliente y mostrar el precio de la entrada. 

Si el cliente es menor de 4 años puede entrar gratis $0
si tiene entre 4 y 18 años debe pagar $5
si es mayor de 18 años, $10

'''
#Parte 1 - Presentación del programa:
print('Este programa calcula el precio a pagar por edades')
print('')

#Parte 2 - Solicitud de información:
edad = int(input('Ingrese la edad del cliente: '))

#parte 3 - Procesamiento de la información y entrega de resultados:
PAGO_1 = 0
PAGO_2 = 5
PAGO_3 = 18

if edad < 4:
    edad = 'niño'
    print(f'El cliente es un {edad}, debe pagar ${PAGO_1}.')
elif edad > 3 and edad < 19:
    edad = 'jóven'
    print(f'El cliente es un {edad}, debe pagar ${PAGO_2}.')
elif edad > 18:
    edad = 'adulto'
    print(f'El cliente es un {edad}, debe pagar ${PAGO_3}.')            