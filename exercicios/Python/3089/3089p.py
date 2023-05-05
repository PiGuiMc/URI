while(True):
    n = int(input())

    p1, p2 = 0,0

    
    if(n == 0):
        break
    
    l = [int(n) for n in input().split()]

    ult = len(l) - 1
    qt_l = len(l)
    if(n == 1):
        print(int(l[0]) + int(l[ult]), int(l[0]) + int(l[ult]))
    else:
        v_p1_1 = int(len(l)/n)
        v_p1_2 = int(len(l)/n - 1)
        
        print(v_p1_2)