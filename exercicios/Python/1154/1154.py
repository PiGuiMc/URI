x = 100
i = 0
soma =0
while x >= 0:
    n = int(input())
    if n < 0:
        break
    if n >= 0:
        i += 1
        soma = soma + n
media = soma / i
print('{:.2f}'.format(media))
