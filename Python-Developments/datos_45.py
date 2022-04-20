'''

Write a program what stor the subjects of a course (for example Mathematics, Physics, Chemistry, History and Language) in
a list and the message I study <signature> shows it on the screen, where <signature> is each of the subjects of the
list

'''
#Part 1 - Presentation of the program
print('This program show i study + subject')

#Part 2 - Processing the information and delivery of results 

subjects = ['Mathematics', 'Physics', 'Chemistry', 'Histry', 'Lenguaje' ]
subjects.sort()

for loop_interaction in subjects:
    print("I study " + loop_interaction)

 