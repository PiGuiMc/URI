n = int(input())

for i in range(0,n):
    v = int(input())
    s = 0
    j = 1
    while j <= v:
        if v % j == 0:
            s = s + 1
        j +=1
    if s > 2:
        print('{} nao eh primo'.format(v))
    else:
        print('{} eh primo'.format(v))
