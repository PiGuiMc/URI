n = int(input())

for i in range(n):
    t = int(input())

    if t > 2015:
        anos = (t - 2015) + 1
        print('{} A.C.'.format(anos))
    elif t < 2015:
        anos = (2015 - t)
        print('{} D.C.'.format(anos))
    
    elif t == 2015:
        print('1 A.C.')