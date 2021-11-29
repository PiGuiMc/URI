n = input().split()

p = int(n[0])
j1 = int(n[1])
j2 = int(n[2])
r = int(n[3])
a = int(n[4])
g1 = 'Jogador 1 ganha!'
g2 = 'Jogador 2 ganha!'

v = 0

if (j1 + j2) % 2 == 0:
    if p == 1:
        v = 1
    else:
        v = 2
else:
    if p == 0:
        v = 1
    else:
        v = 2

if r == 1 and a == 1:
    print(g2)

elif r == 1 and a == 0:
    print(g1)

elif r == 0 and a == 1:
    print(g1)

elif r == 0 and a == 0:
    if v == 1:
        print(g1)
    elif v == 2:
        print(g2)
