'''Este programa va a calcular el área de un triangulo base/altura, todo pedido por pantalla'''
#Parte 1 - Presentación del programa
print ('Este programa le ayudará a cálcular el área de un triangulo en cm. Ingrese los datos a continuación')
print ('')

#Parte 2 - Solicitud de datos
base = float(input('Por favor ingrese la base de su triangulo en cm: '))
print ('')

altura = float(input('Por favor ingrese la altura de su triangulo en cm: '))
print ('')

#Parte 3 - Operaciones
area = base * altura / 2

#Parte 4 - Entrega de resultados
print (f'El área de su triangulo es: {area} cm, gracias por jugar.')
input()