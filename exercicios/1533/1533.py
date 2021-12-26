while True:
    n = int(input())
   
    if n == 0:
        break

    lista = input().split()
    
    for i in range(n):
        lista[i] = int(lista[i])

    
    ord = sorted(lista, key=int)

    for ind, i in enumerate(lista):
        if i == ord[n-2]:

            print(ind+1)
            break