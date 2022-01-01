j = 0
p = 0
for i in range(15):
    v = int(input())

    if v % 2 == 0:
        
        if j == 5:
            print('par[{}] = {}'.format(j,v))
            
            j = 0
        j = j + 1
    else:
        print('impar[{}] = {}'.format(p,v))
        p = p + 1
        if p == 5:
            p = 0
    i = i + 1