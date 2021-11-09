n=int(input())

a = input()

a = a.split()

for i in range(len(a)):
    a[i] = int(a[i])

    menor = a[0]
    posicao = 0
    for j in range(1,len(a)):
        if a[j] < menor:
            print('1')        
        if a[j] >= 10 and a[j] <= 20:
            print('2')
        if a[j] >= 20:
            print('3')