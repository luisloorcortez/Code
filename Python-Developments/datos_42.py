'''

Write a program to store a string "password" in an variable, ask to the user for the password, the program must wait until 
the user enter the correct password.

'''
#constant variable
PASSWORD = 'password'

#modules
import os

#flag to ciclo
ciclo = True

#acumulator
retry = 0


while ciclo:
    
    #Objetives of the program
    os.system('cls')
    print('this pogram is a password verificator')
    print('')

    #information request
    password = input('User: enter the password, please: ')

    #Information processing and delivery of result

    
    if password != PASSWORD:
        if  retry == 2:
            print('you entered wrong password 3 times... try later. bye :)')
            print('')
            ciclo = False    
        else:
            print(f'the password entered is wrong, you have {2 - retry} chance')
            print('')
            #attempt acumulator
            retry = retry + 1
            input('hit any key to retry...')

    else:
        print('Password entered is corret. Wellcome!')
        ciclo = False
        print('')
        input('Hit any key for retry...')
      
