''' Este programa es un validador de credeciales '''

#variables
USUARIO = 'marcos'
CONTRASEÑA = '1234'

#Parte 1 - Preesentación del programa
print('Este programa validará sus credenciales')
print('')

#Parte 2 - Solicitud de información
usuario = input('Por favor escriba su usuario: ')
print('')

contraseña = input('Por favor escriba su contraseña: ')
print('')

#Parte 3 - Ejecución y entrega de información
if usuario == USUARIO and contraseña == CONTRASEÑA :
    print (f'El usuario {usuario} está en el sistema, puede ingresar')
else:
    print (f'El usuario {usuario} no está en el sistema, PERMISO DENEGADO')

print('')
print('Adios :)')
input()  