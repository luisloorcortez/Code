'''Este programa es una cálculadora de índice de peso corporal'''

#Bandera
ciclo = True

while ciclo:

    #Parte 1 - Presentación del programa.
    print('Este programa es una cálculadora del índice de peso corporal')
    
    #Parte 2- Recolección de información.
    def cal_pes_cor ():
        LIBRA = 1
        KILOS = 2
        menu = int(input(f'''   
        Calculadora de peso corporal

        Elije que que formato ingresarás tu peso
        {1}) Libras
        {2}) kilos

        :  '''))
        
        #Parte 3- Análisis de la información
        if menu == 1:
            print('')
            peso = float(input('Por favor ingrese su peso en libras: '))
            altura = float(input('Por favor ingrese su altura en metros: '))
            pesocorporal = (peso * 2.20) / (altura**2)
        else:
            peso = float(input('Por favor ingrese su peso en kilos: '))
            altura = float(input('Por favor ingrese su altura en metros: '))
            pesocorporal = peso / (altura**2)

        return pesocorporal

    #pesocorporal = cal_pes_cor() #Parte 4 - Entrega de resultados
    #Parte 4 - Entrega de resultados #Parte 4 - Entrega de resultados
    print('')
    print(f'Usuario, tu índice de peso corporal es: {cal_pes_cor() :.2f}')
    
    print('')
    control = input('Usuario: presiona enter para repetir o 0 para salir: ')
    if control == '0':
        ciclo = False
    
