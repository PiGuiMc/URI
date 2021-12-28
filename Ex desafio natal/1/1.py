n = int(input())

i = 1
b,a,r,c,e,l,g,s,j,p = 0,0,0,0,0,0,0,0,0,0
while i <= n:
    entrada = input().split()
    nome = str(entrada[0])
    esp = int(entrada[1])

    if esp == 1:
        b += 1
    elif esp == 2:
        a +=1
    elif esp == 3:
        r +=1
    elif esp == 4:
        c += 1
    elif esp == 5:
        e += 1
    elif esp == 6:
        l += 1
    elif esp == 7:
        g += 1
    elif esp == 8:
        s += 1
    elif esp == 9:
        j += 1
    elif esp == 10:
        p += 1

    i += 1

print('Total de Brinquedos: {}'.format(b))
print('Total de Alimentos: {}'.format(a))
print('Total de Roupas: {}'.format(r))
print('Total de Calcados: {}'.format(c))
print('Total de Eletronicos: {}'.format(e))
print('Total de Livros: {}'.format(l))
print('Total de Gadgets: {}'.format(g))
print('Total de Smartphones: {}'.format(s))
print('Total de Jogos: {}'.format(j))
print('Total de Papelaria: {}'.format(p))
