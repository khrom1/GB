#  Определить индексы элементов массива (списка),
# значения которых принадлежат заданному диапазону 
# (т.е. не меньше заданного минимума и не больше заданного максимума)
import random
size = int(input('Введите размер массива: '))
min_number = int(input('Введите минимальный элемент : '))
max_number = int(input('Введите максимальный элемент : '))
list_1 = []
for _ in range(size):
    list_1.append(random.randint(min_number, max_number))
print(list_1)    
min_range = int(input('Введите минимум диапазона: '))
max_range = int(input('Введите максимум диапазона: '))
for i in range(size):
    if min_range <= list_1[i] <= max_range:
       print(i, end=' ')

print()