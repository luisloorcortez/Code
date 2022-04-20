'''
Los tramos impositivos para la declaración de la renta en un determinado país son los siguientes:
Menos de 10000€	5%
Entre 10000€ y 20000€	15%
Entre 20000€ y 35000€	20%
Entre 35000€ y 60000€	30%
Más de 60000€	45%
Escribir un programa que pregunte al usuario su renta anual y muestre por pantalla el tipo impositivo que le corresponde.

'''
#Parte 1 - Presentación del prograama
print('Este programa cálcula cuanto le toca pagar de renta \nPor favor, ingresa solo números')
print('')
#Parte 2 - Solicitud de información
renta = float(input('Usuario: Ingresa tu renta anual: '))
#Parte 3 - Procesado de información
if renta < 10000:
    print(f'Usuario: Te toca pagar de renta ${renta * 0.05 :.2f}')
elif renta >= 10000 and renta <= 20000:
    print(f'Usuario: Te toca pagar de renta ${renta * 0.15 :.2f}')
elif renta >= 20001 and renta <= 35000:
    print(f'Usuario: Te toca pagar de renta ${renta * 0.20 :.2f}')
elif renta >= 35001 and renta <= 60000:
    print(f'Usuario: Te toca pagar de renta ${renta * 0.30 :.2f}')
elif renta > 10000:
    print(f'Usuario: Te toca pagar de renta ${renta * 0.45 :.2f}')

print('')
input('Presiona enter para salir...')