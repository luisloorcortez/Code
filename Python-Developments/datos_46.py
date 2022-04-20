'''
white the program what store the subjects of the curse (for example Mathematic, physics, Chimistry, History and lenguaje) in a list, 
ask to the user the note obtained each subjects, and later show in the the display with the messege in <subjects> you have obtained
the <note> where subjects is each of the subjects in the list and <nota> each of the correspondent note introduced for the user. 

'''
#Part 1 - Presentation of the program

print('This program show the note obtained by the user')

#Part 2 - The information request

subjects = ['Mathematics', 'Physics', 'Chimistry', 'History', 'Lenguage']
final_note = []

#Part 3 - Processing the information and felivery of result

for loop_1 in subjects:
    note = input('User: Enter the qualification obtained by the user in: ' + loop_1 + '?: ')
    final_note.append(note)
    

for loop_2 in range(len(subjects)):
    print('the note in ' + subjects[loop_2] + ' is ' + final_note[loop_2])

input('Hit enter for exit...')