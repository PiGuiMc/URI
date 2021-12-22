
while True:
    pa,pb = 0,0

    n =  int(input())

    if n == 0:
        break

    a = [int(x) for x in input().split()]
    b = [int(x) for x in input().split()]

    if a[0] == a[1] and a[0] == a[2] and b[0] != b[1] and b[0] != b[2]:
        pa += 30
    elif a[0] != a[1] and a[0] != a[2] and b[0] == b[1] and b[0] == b[2]:
        pb+=30

    for i in range(n):
        if a[i] >=0:
            pa+=a[i]
        if b[i]>=0:
            pb+=b[i]
    
    if pa == pb:
        print('T')
    elif pa > pb:
        print('M')
    elif pb > pa:
        print('L')
