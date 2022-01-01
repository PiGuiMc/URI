n = int(input())

i = 1
a,e,h,m,x = 0,0,0,0,0
while i <= n:
    nome, esp = input().split()

    if esp == 'A':
        a += 1
    elif esp == 'E':
        e +=1
    elif esp == 'H':
        h +=1
    elif esp == 'M':
        m += 1
    elif esp == 'X':
        x += 1

    i += 1

print('{} Hobbit(s)'.format(x))
print('{} Humano(s)'.format(h))
print('{} Elfo(s)'.format(e))
print('{} Anao(s)'.format(a))
print('{} Mago(s)'.format(m))