x = int(input())

l = list(range(x))

u_x = x - 1
v = 1
l[x-1] = 1
l[x-2] = 1
for i in reversed(range(0,x-2)):
    l[i] = l[i+1] + l[i+2]

saida = ''

for v in range(len(l)):
    saida += str(l[v]) + ' '
saida = saida[:-1]
print(saida)