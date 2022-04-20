''' Continuamos con los ejercicios de prácticas de las estructuras de repetición'''
#Parte 1 - Este programa generará tablas de miltiplicar de forma autormática

#Bandera
ciclo = True



while ciclo:

    print('Este programa creará tabla de multiplicar del 1 hasta el 10')
    print('')      
    
    for numero in range(1, 11):
        print('')
        numtabla = numero
        print(f'Está es la tabla del: {numtabla}')

        for resultado in range(1, 11):
            print(f'{numtabla} * {resultado} = {numtabla * resultado}')
    
    else:
        control = input('Presione enter para continuar, o 0 para terminar...: ')
        if control == '0':
            ciclo = False 

input()            