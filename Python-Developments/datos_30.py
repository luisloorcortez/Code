#Perte 1 - Presentación del programa.
print('Este programa crea un cronometro')

#Parte 2 - Solicitud de información
hora = int(input('Usuario: Ingresa las horas: '))
minutos = int(input('Usuario: Ingresa los minutos: '))
#segundos = int(input('Usuario: Ingresa los segundos: '))
modo = int(input('Usuario: Selecciona 1 para modo ascendente, 2 para descendente: '))

#Parte 3 - Analisis y entrega de resultados

import time
import os

if (hora < 0 or hora > 100) or  (minutos < 0 or minutos > 59):
	print('Solo acepto hasta 100 horas y 59 minutos')
		
elif modo != 1 and modo != 2:
	print('Solo acepto los números 1 y 2')
		
else:
	if modo == 1:
		for hor in range(0, hora, 1):
			for min in range(0, minutos, 1):
				for seg in range(0, 59, 1):
					os.system('cls')
					print(f'{hor} : {min} : {seg}')
					time.sleep(1)
	else:
		for hor in range(hora, 0, -1):
			for min in range(minutos, 0, -1):
				for seg in range(59, 0, -1):
					os.system('cls')
					print(f'{hor} : {min} : {seg}')
					time.sleep(1)
