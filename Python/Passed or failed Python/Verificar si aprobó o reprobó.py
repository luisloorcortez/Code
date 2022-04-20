'''VErificar si aprobó el curso'''


#Ejercicio 5 - Redondear calificación
#Presentación del programa
print('Este programa le dirá si aprobó el curso por calificaión y asistencia')
print('')

#Constantes
MIN_CAL = 60
MIN_ASIS = 24


#Solicitud de información 
calificaión = int(input('Por favor ingrese su calificación: '))
print('')

asistencia = int(input('Por favor ingrese su asistencia: '))
print('')
#Proceso y entrega de datos

if calificaión >= MIN_CAL and asistencia >= MIN_ASIS :
    print(f'felicidades, aprobaste el curos con: {asistencia} puntos de asistencia y: {calificaión} puntos de calificaión')
elif calificaión >= MIN_CAL and asistencia < MIN_ASIS :
    print(f'No aprobaste el curso, fallaste  tu asistencia con: {asistencia} puntos')
elif calificaión < MIN_CAL and asistencia >= MIN_ASIS :
    print(f'No aprobaste el curso, fallaste  tu calificaión con: {calificaión} puntos')
else:
    print(f'No aprobaste el curso, fallaste en calificaión: {calificaión} y asistencia: {asistencia}')
print('')
print('Adios :)')


    






















