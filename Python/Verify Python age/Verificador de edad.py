'''Este programa solicitira loa edad al usuario y lo pasará por un bloque de codigo precargado'''

# Parte 1 - Presentar el programa
print('Este programa verificará si es mayor de edad')
# Parte 2 - Solicitar los datos
# Procedimientos


def Menú_VerificarEdad(años, usuario):
    # Bandera
    ciclo = True

    while ciclo:
    # Parte 1 - Usaremos un procedimiento para imprimir un mensaje en pantalla.

        # Solicitud de nombre
        if años < int(18):
            print(f'El usuario: {usuario}, es menor de edad. Tienen: {años} años')
        else:
            print(f'El usuario: {usuario}, es mayor de edad. Tienen: {años} años')

    
        # Parte 2 - Sección de control de repeticóon 
    

        print('')    
        seleccion = input('Presione enter para continuar, o 0 para salir: ')
        if seleccion == '0':
            ciclo = False


print('')
usuario = input('Usuario: Escribe tu nombre: ')
        # print(f'Buenas tardes, {usuario}. Es un placer saludarte')
años = int(input('Usuario: Escribe tu edad: '))

# Parte 3 - Realizar las operaciones y entreego resultados
Menú_VerificarEdad(años, usuario)
input()  


