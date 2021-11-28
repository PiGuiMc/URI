o=input()
m = []
tamanho = 12
for i in range(tamanho):
    m.append([])
  
    for j in range(tamanho):
        x = float(input())
        m[i].append(x)

for i in range(tamanho):
    for j in range(tamanho):
        print(m[i][j], end=' ')
    print()


if o == 'S':
    s = 0
    c = 11
    for i in range(11,0,-1):
        for j in range(0,c):
            s = s + m[i][j]
        c = c -1
    print('{:.1f}'.format(s))

if o == 'M':
    s = 0
    c = 11
    c2=0
    for i in range(11,0,-1):
        for j in range(0,c):
            s = s + m[i][j]
            c2= c2 + 1
        c = c - 1
       
    m=s/(c2)
    print('{:.1f}'.format(m))