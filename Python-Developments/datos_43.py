'''
Write a program to show the eco of the all what the user enter until the user write exit, next the program end.

'''

#modules
import os


#Part 1 - Presenting of the program
print('This program is a eco reproducer')
print('')

#Part 2 - information request 
os.system('cls')

eco = input('User: enter any word: ')
print('')

#Part 3 - Precesing and delivery of information
#flag of ciclo
ciclo = True
#Acumulator
repeat = 0


while ciclo:
    os.system('cls')
    repeat= repeat + 1
    print(f'This is the try # {repeat}')
    print('User: The word ingresed is: ' + eco)
    retry = input('User: write exit for end, or hit enter for continue: ')
    if retry == 'exit':
        ciclo = False
        print('bye, Dooooog :)')
    print('')
