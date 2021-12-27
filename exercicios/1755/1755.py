n = int(input())

for i in range(n):
    valores,aux = [],[]
    qt,x,menor = 0,0,0

    d,itens = map(int,input().split())

    
    valores = [float(itens) for itens in input().split()]
    valores.append(valores)
    for k in range(itens):
        if (valores[k] * qt <= d):
            qt+=1
        else:
            qt -= 1

    for j in range(itens):
        x = d - qt * valores[j]
        if x > 0:
            aux.append(x)
            aux = sorted(aux)
            menor = min(aux)

    print('{:.2f}'.format(menor))