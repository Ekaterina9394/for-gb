# Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
# 1 -> x > 0, y > 0
#        |y
#     2  |  1
#   _____|_____x
#        |
#     3  |  4
# чтобы получить 3 нужно чтобы х и у были
# отриц. чтобы получить 2 то х (-) у(+) и тд

number = input("Введите число от 1 до 4: ")
number = int(number)
if number == 1:
    print("1 -> (x > 0, y > 0)")
elif number == 2:
    print("2 -> (x < 0, y > 0)")
if number == 3:
    print("3 -> (x < 0, y < 0)")
elif number == 4:
    print("4 -> (x > 0, y < 0)")