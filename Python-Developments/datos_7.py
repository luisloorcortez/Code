'''
Escribir un programa que pida al usuario su peso (en kg) y estatura (en metros), calcule el índice de masa corporal y lo 
almacene en una variable, y muestre por pantalla la frase Tu índice de masa corporal es <imc> donde <imc> es el índice de 
masa corporal calculado redondeado con dos decimales.

'''

#Parte 1 - Presentación del programa

print('Este programa es una cálculadora de imc')
print('')


#Parte 2 - Solicitud de información

peso = float(input('Por favor ingresa tu peso en kilogramos: '))
altura = float(input('Por favor  ingresa tua altura en metros: '))

#Parte 3 - Proceso y entrga de resultados

imc = peso / altura ** 2
print(f'Tu ínfice de imc es : {imc :.2f}')

input('Presione enter para continuar...')
