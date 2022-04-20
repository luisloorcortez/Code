'''Como saber si un númro es entero'''
#solicitamso un número al usuario

user_input = input("Enter the input ")

try:
    int(user_input)
    it_is = True
except ValueError:
    it_is = False

print(it_is)
