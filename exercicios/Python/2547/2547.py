
while True:
    qt = 0
    try:
        v, Amin, Amax = map(int,input().split())

        for i in range(v):
            A = int(input())

            if A >= Amin and A <= Amax:
                qt +=1

        print(qt)

    except EOFError:
        break