while 1:

    t = int(input())

    if t ==0:
        break

    for i in range(t):
        v = int(input())

        if v % 2 == 0:
            print(v * 2 - 2)
        else:
            print(v * 2 - 1)    
        

