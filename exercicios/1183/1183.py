o=input()
m = []
tamanho = 12
for i in range(tamanho):
    m.append([])
  
    for j in range(tamanho):
        x = float(input())
        m[i].append(x)

if o == 'S':
    s = 0
    c = 1
    for i in range(0,tamanho-1):
        for j in range(c,tamanho):
            #print('m[{}][{}]'.format(i,j))
            s = s + m[i][j]
        c = c + 1
    print('{:.1f}'.format(s))

if o == 'M':
    s = 0
    c = 1
    c2=0
    for i in range(0,tamanho-1):
        for j in range(c,tamanho):
            #print('m[{}][{}]'.format(i,j))
            s = s + m[i][j]
            c2= c2 + 1
        c = c + 1
      
    m=s/(c2)
    print('{:.1f}'.format(m))