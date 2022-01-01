g = 0
a = 0
d = 0

while True:
    x = int(input())

    if(x == 1):
        a += 1
    elif(x == 2):
        g += 1
    elif(x == 3):
        d += 1

    elif(x == 4):
        break

print('MUITO OBRIGADO')
print('Alcool: %d'%a)
print('Gasolina: %d'%g)
print('Diesel: %d'%d)