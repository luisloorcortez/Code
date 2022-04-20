'''
En una determinada empresa, sus empleados son evaluados al final de cada año. Los puntos que pueden obtener en la evaluación 
comienzan en 0.0 y pueden ir aumentando, traduciéndose en mejores beneficios. Los puntos que pueden conseguir los empleados 
pueden ser 0.0, 0.4, 0.6 o más, pero no valores intermedios entre las cifras mencionadas. A continuación se muestra una tabla 
con los niveles correspondientes a cada puntuación. La cantidad de dinero conseguida en cada nivel es de 2.400€ multiplicada 
por la puntuación del nivel.

Nivel	    Puntuación        Bono
Inaceptable	   0.0        *   2400
Aceptable	   0.4        *   2400
Meritorio	   0.6 o más  *   2400

Escribir un programa que lea la puntuación del usuario e indique su nivel de rendimiento, así como la cantidad de dinero que 
recibirá el usuario.

'''
#Parte 1 - Presentación del programa
print('Este programa cálcula el rendimiento y la bonificación ganada por empleado')
print('')

#Parte 2 - Solicitud de infromación
BONO_PAGAR = 2400

empleado = input('Por favor ingresa el nombre del empleado: ')
puntaje = float(input(f'por favor ingresa el puntaje de {empleado}: '))

#Parte 3 - Prcesamiento y presentación de la información
#Verificador de rango ingresada:
if puntaje < 0.0 or puntaje > 1:
    print('La califiación insertada está fuera del rango permitido...')
#Procesamiento de la información y entrega de resultados:
else:
    print('')
    print(f'El empleado: {empleado} tiene una rendiminto del: {puntaje * 100}% y cobrará de bono de: ${(puntaje * 10) * BONO_PAGAR :.2f}')

