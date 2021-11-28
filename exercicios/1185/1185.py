O = input()

tamanho = 3
matriz = []

for i in range(tamanho):
    linha = []
    for j in range (tamanho):
        linha.append(float(input()))
    matriz.append(linha)

v =[]
n = tamanho
for l in range(0,tamanho - 1):
    n -= 1
    for c in range(0,n):
        v.append(matriz[l][c])

"""for i in range(tamanho):
    for j in range(tamanho):
        print(matriz[i][j], end=' ')
    print()"""

resultado = 0
if O == 'S':
    resultado = sum(v)
else:
    resultado = sum(v) / len(v)

print('{:.1f}'.format(resultado))