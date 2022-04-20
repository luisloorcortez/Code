''' Haremos un menú usando estructuras de selección multiples'''
#Parte 1 - Presentación del programa
print('Este menú le mostrará la capital del páis que seleccione')
print('')

pais = input('''Selecione el país: 
1) para Ecuador, 
2) para Colombia, 
3) para Perú, 
4) para Bolivia

: ''')
print('')

if pais == '1' :
    pais = 'Ecuador'
    print(f'La capital de: {pais} es Quito.')

elif pais == '2' :
    pais = 'Colombia'
    print(f'La capital de: {pais} es Cali.')

elif pais == '3' :
    pais = 'Perú'
    print(f'La capital de: {pais} es Lima.')

elif pais == '4' :
    pais = 'Bolivia'
    print(f'La capital de: {pais} es La Paz.')

else:
    print(f'Su selección: {pais}, no está en el menú.')

print('')
print('Adios :)')
print('')
input()
