x = int(input())

for i in range(x):
    v = input().split()
    f1 = int(v[0])
    f2 = int(v[1])
    
    menor, maior, teste = 0,0,0
    
    if(f1 > f2):
        maior = f1
        menor = f2
    if(f1 < f2):
        maior = f2
        menor = f1
    
    teste = int(menor / 2)



    print(teste)
    
