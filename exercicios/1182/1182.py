c = int(input())
t = input()

tamanho = 3
matriz = []

for i in range(tamanho):
    matriz.append([])

for i in range(tamanho):
    for j in range(tamanho):
        matriz[i].append(float(input()))

for i in range(tamanho):
    for j in range(tamanho):
        print(matriz[i][j], end=' ')
    print()

soma = 0
for i in range(tamanho):
    soma += matriz[i][c]

resultado = soma
if t == 'M':
    resultado = soma / tamanho
print('{:.1f}'.format(resultado))