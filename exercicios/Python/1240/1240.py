x = int(input())

for i in range(x):
    txt = input().split()
    a = txt[0]
    b = txt[1]

    menor = int(b)
    maior = int(a)

    print('encaixa') if(int(maior[len(menor)-1:len(maior)]) == int(menor)) else print('nao encaixa')
