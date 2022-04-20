'''
Escribir un programa que pida al usuario dos números y muestre por pantalla su división. Si el divisor es cero el programa 
debe mostrar un error.

'''
#Parte 1 - Presentación del programa
print('Este programa es una cálculadora para dividir 2 números')

#Parte 2 - Solicitud de información
dividendo = float(input('Usuario: Ingresa tu primer número: '))
divisor = float(input('Usuario: Ingresa tu segundo número: '))

#Parte 3 - Realizar operaciones y entregar resultados
if divisor == 0:
    print('')
    print('ERROR')
else:
    print('')
    print(f'Usuario: El resultado de la división es: {dividendo//divisor}')

print('')
input('Presiona enter para terminar')