n = int(input())
vg = 0
a,d,l = 0,0,0
vg = []
for i in range(n):
    b = int(input())

    for j in range(2):

        x = input().split()
        a = int(x[0])
        d = int(x[1])
        l = int(x[2])
        vg.append(j)

        vg[j] = ((a + d)/ 2 )

        if l % 2 == 0:
            vg[j] += b
        
    if vg[0] < vg[1]:
        print('Guarte')
    elif vg[0] == vg[1]:
        print('Empate')
    elif vg[0] > vg[1]:
        print('Dabriel')

        
