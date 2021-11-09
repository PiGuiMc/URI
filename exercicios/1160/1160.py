n = int(input())
i = 0
por = float(0)

while i <= n:
    pa,pb,g1,g2 = list(map(float,input().split()))

    if pa < pb:
        if g1 >= g2:
            por = ((pb - pa) * (g1 - g2)) + 1
            print('{:.0F}'.format(por),'anos.')
        
        if g1 <= g2:
           por = ((pb - pa) * g1) + 1
           print('aqui')
           print('{:.0F}'.format(por),'anos.')