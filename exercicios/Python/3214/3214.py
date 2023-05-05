valor = input().split()
total = 0

e = int(valor[0])
f = int(valor[1])
c = int(valor[2])

total_garrafas = e + f

while(total_garrafas >= c):
    total += int(total_garrafas / c)
    total_garrafas = int(total_garrafas / c) + int(total_garrafas % c)

print(total)