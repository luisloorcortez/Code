'''
Escribir un programa que pregunte por consola el precio de un producto en euros con dos decimales y muestre por pantalla 
el número de euros y el número de céntimos del precio introducido.

'''
precio = input("Introduce el precio del producto con dos decimales:  ")
print(precio[:precio.find('.')], 'euros y', precio[precio.find('.')+1:], 'céntimos.')

#El ejercicio de arriba en la primera parte borra todo lo qu esta dspues del string que busca, el segundo orra todo antes del string 
#que busca, además agrega +1 para que elimine un steing más.