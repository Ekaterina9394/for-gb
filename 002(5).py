# на вход подается 4хзначиное число. получите 
# список из цифр данного числа увеличенных на 10
# 9650 ---- [19, 16, 15, 10]

N = list(input("Введите четырехзначное число: "))

result = lambda x: int(x) + 10
result = list((map(result, N)))
print("получаем", result)