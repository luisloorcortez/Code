'''
Escribir un programa que pregunte el correo electrónico del usuario en la consola y muestre por pantalla otro correo 
electrónico con el mismo nombre (la parte delante de la arroba @) pero con dominio ceu.es.

'''

#Parte 1 - Presentación del Programa
print('Este programa corta unstring y reeplaza valores')
#Parte 2 - Entrega de información
email = input("Introduce tu correo electrónico: ")
print('yocortocaracteres' + email[email.find('@'):])  #Esta función busca y corta caracteres apartir del string que le indiques.
