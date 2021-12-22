while True:
    k = int(input())

    if k == 0:
        break
    i = 0
    while i < k:
        x,y = map(int,(input().split()))

        if x == y:
            print('divisa')
            i -=1
        elif  x == 0 and y > 0 or x == 0 and y < 0 or y == 0 and x > 0 or y == 0 and x < 0:
            print('divisa')

        elif x > 0 and y > 0:
            print('NE')  
        elif x < 0 and y > 0:
            print('NO')

        elif x < 0 and y < 0:
            print('SO')
        elif x > 0 and y < 0:
            print('SE')
        i +=1