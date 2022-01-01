n = int(input())
car = 0
bon = 0
for i in range(n):
    nome,sexo = input().split()
    
    if sexo == 'M':
        car += 1
    elif sexo == 'F':
        bon += 1
print('{} carrinhos'.format(car))
print('{} bonecas'.format(bon) )