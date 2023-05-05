op = int(input())

bon, arq, mus, des, total = 0,0,0,0,0

for i in range(op):
    nome, trab, hora = input().split()

    if trab == 'bonecos':
        bon += int(hora)
        
    elif trab == 'arquitetos':
        arq += int(hora)
        
    elif trab == 'musicos':
        mus += int(hora)
        
    elif trab == 'desenhistas':
        des += int(hora)

total += (int(bon/8) + int(arq/4) + int(mus/6) + int(des/12))

print(total)