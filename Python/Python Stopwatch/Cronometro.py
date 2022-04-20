'''Este programa es cronómetro de cuenta regresiva, con 24 horas cargadas'''

#Parte 1 - presentación del programa
print('Este es un cronometro de 24 horas')

#Módulos importados
import time
import os

#Desarrollo del ejercicio
#Conteo horas
for horas in range(24):  
    
    #Conteo minutos
    for minutos in range(60):
        
        #onteo segundos
        for segundos in range(60):  
            os.system('cls')
            print(f'{horas} : {minutos} : {segundos}') 
            
            #Para detener la consola 1 seg
            time.sleep(1)
else:
    print('Ha terminado el conteo')
