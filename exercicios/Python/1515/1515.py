while True:
    planeta=[]
    ano = []
    tempo = []
    menor =[]
    n = int(input())

    if n == 0:
        break

    for i in range(n):

        entrada = input().split()

        planeta.append(entrada[0])
        ano.append(int(entrada[1]))
        tempo.append(int(entrada[2]))

    for x in range(n):
            
            menor.append(ano[x] - tempo[x])
            
    menor_ind = menor.index(min(menor))
    print(planeta[menor_ind])
