'''
in this document we wiil parctice the list


#way 1 - the classic mode
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
#The espaces are: 0         1         2       3        4                in the memorie

#way 2 - the list in the list mode
list_way_two = ['black', 'pink', ['yellow', 'white', 'orange']]
#The espaces are: 0         1                  2                        in the memorie  

#way 3.1 - the module wiht tupla list mode
list_way_three =  list('other', ('black', 'red', 'orange', 'black', 'yellow'))
#The espaces are:          0       1        2         3        4        in the memorie

#way 3.2 - The range in the list mode
list_way_four = list('other', range(1, 10))

#The spaces in the memorie are ten, the some as the range 

test = [list]
print(dir(test))

The methods for de list:
'append', 'clear', 'copy', 'count', 'extend', 'index', 'insert', '0', 'remove', 'reverse', 'sort', 'len'
 
#How show any item in the list the method is
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']

print(list_way_one [2]) 

#how know if the element is in the list the method is
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
print ('black' in list_way_one) 

#how replace elements in the list the method is
#The way 1 - the classic method, select the index number for change
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
list_way_one [3] = 'other'
print(list_way_one)

#The way 2 - replace space in the list for other list, too select the number index for change
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
list_way_one [3] = ['this', 'is', 'the', 'new', 'list']
print(list_way_one)

#How add more element in the list
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
#way 1 - one be one
list_way_one.append('red')
print(list_way_one)
#way 2 - insert other list in the list
list_way_one.append(['red', 'purple', 'brown'])
print(list_way_one)

#How to extend a list
#way 1 - extend one be one
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']

list_way_one.extend(['red'])
print(list_way_one)

#way 2 - extend other list in the list
list_way_one.extend(['purple', 'brown'])
print(list_way_one) 

#How insert element in specifit site
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
#way 1 - the classic method
list_way_one.insert(2, 'other_1')
print(list_way_one)

#way 2 - the inverse method
list_way_one.insert(-2, 'other_2')
print(list_way_one)
 
#way 2 - the len method
list_way_one.insert(len(list_way_one), 'other_3')
print(list_way_one)

#How remove element of the list
#way 1- rermove idex specifit using pop()
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']
list_way_one.pop(1)
list_way_one.pop()
print(list_way_one)

#way 1- using rermove
list_way_one.remove('black')
print(list_way_one)

#How clear the list
list_way_one.clear 

#How order the list
list_way_one = ['black', 'yellow', 'pink', 'white', 'orange']

list_way_one.sort()
print(list_way_one)

list_way_one.sort(reverse=True)
print(list_way_one)

#How print index in the list
list_way_one = ['black', 'yellow', 'pink','pink', 'white', 'orange']
print(list_way_one.index('black'))

#How count elements in the table
print(list_way_one.count('pink'))'''







