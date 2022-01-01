while True:
    rep = 0

    n,b = map(int,input().split())

    if n == 0 and b == 0:
        break

    
    lista = [str(x) for x in input().split()]
    lista = sorted(lista)
    
    for i in range(b-1):
        if lista[i] == lista[i + 1]:
            rep+=1
    if rep > 1:
        rep -=1

    print(rep)