'''
Escribir un programa que pregunte al usuario la fecha de su nacimiento en formato dd/mm/aaaa y muestra por pantalla, 
el día, el mes y el año. Adaptar el programa anterior para que también funcione cuando el día o el mes se introduzcan 
con un solo carácter.

'''

fecha = input("Introduce la fecha de tu nacimiento en formato dd/mm/aaaa: ")
print('Día', fecha[:2])
print('Mes', fecha[3:5])
print('Año', fecha[6:])

#Adaptar el programa anterior para que también funcione cuando el día o el mes se introduzcan con un solo carácter.

echa = input("Introduce la fecha de tu nacimiento en formato día/mes/año: ")

dia = fecha[:fecha.find('/')]
mesaño = fecha[fecha.find('/')+1:]
mes = mesaño[:mesaño.find('/')]
año = mesaño[mesaño.find('/')+1:]

print('Día', dia)
print('Mes', mes)
print('Año', año)