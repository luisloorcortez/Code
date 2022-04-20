'''Este programa va a generar numero con los atos ingresados por el usuario'''
#Parte 1 - ¨resentación del programa
print('Este programa es una calculadora')
print('')
#Parte 2 - Ingreso de la información
#procesos - módulos

ciclo = True
while ciclo:

    def calculador (numtabla, exttabla):
        
        
        for resultado in range(0, exttabla):
                print(f'{numtabla} * {resultado +1} = {numtabla * (resultado +1)}')
                

    print('')
    numtabla = float(input('Por favor, ingrese el número de la tabla que desea ver: '))
    exttabla = int(input('Por favor, ingrese hasta que número dese multiplicar su tabla: '))
        
    #Parte 3 - Proceso y salida de resultados

    calculador (numtabla, exttabla)
    
    control = input('Presione enter para continuar, o 0 para terminar...: ')
    if control == '0':
        ciclo = False

input()  

