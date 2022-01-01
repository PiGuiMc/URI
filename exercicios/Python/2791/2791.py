lista = [int(x) for x in input().split()]

for i in range(len(lista)):
    if lista[i] == 1:
        print(i + 1)