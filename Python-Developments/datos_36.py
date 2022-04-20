'''
Escribir un programa que pregunte al usuario su edad y muestre por pantalla todos los años que ha cumplido (desde 1 hasta su edad), además 
muestre el número de cilcos que haya realizado.

'''
#Parte 1 - Presentación del programa
print('Este programa le mostrara por pantalla desde el 1 hasta la edad que el usuario ingrese')
print('')

#Parte 2 - Solicitud de información al usuario
edad = int(input('Usuario: Ingresa tu edad: '))
print('')

#Parte 3 - Procesamiento y entrega de la información
#acumulador
ciclo = 0

for i in range(1, (edad + 1)):
    print(f'Usuario: este ese el año: {i}')
    ciclo = ciclo + 1

print('')
input(f'Usuario: He hecho {ciclo} ciclos. Presiona una tecla para terminar...')