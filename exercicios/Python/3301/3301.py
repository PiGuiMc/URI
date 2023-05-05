while(True):
    try:
        v = input().split()

        h = int(v[0])
        z = int(v[1])
        l = int(v[2])

        if(h == z and h == l or z == l or h < z and h == l  or z < h and z == l or l < h and z == h):
            continue
        elif(h < l and h > z or h > l and h < z):
            print('huguinho')
        elif(z < l and z > h or z > l and z < h):
            print('zezinho')
        elif(l < h and l > z or l > h and l < z):
            print('luisinho')
        
    except EOFError:
        break