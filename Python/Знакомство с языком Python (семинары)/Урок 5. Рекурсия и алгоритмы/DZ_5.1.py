# Напишите программу, которая на вход принимает два числа A и B,
# и возводит число А в целую степень B с помощью рекурсии.

def pow(x, y):
    if y == 0:
        return 1
    else:
        return x * pow(x, y - 1)
a = int(input('Введите A: '))
b = int(input('Введите B: '))
res = pow(a, b)
print(f'{a} в степени {b} = {res}')