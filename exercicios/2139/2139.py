dM = [31,29,31,30,31,30,31,31,30,31,30,31]

while 1:
    try:

        v = input()
        v=v.split('')
        m = int(v[0])
        d = int(v[1])
        tt = 0
        
        if d == 25 and m == 12:
            print('E natal!')
                
        elif d == 24 and m == 12:
            print('E vespera de natal!')
        elif d > 25 and m == 12:
            print('Ja passou!')

        else:
            for i in range(m - 1, len(dM)):
                tt += dM[i]
            
            tt -= d
            tt -=6
    except:
        break