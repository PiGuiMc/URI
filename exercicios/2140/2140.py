n = [4,7,12,15,22,25,30,40,52,55,60,70,100,102,105,110,120,150,200]

while 1:
    try:
        v = input()
        v = v.split(' ')
        t = int(v[0])
        p = int(v[1])

        troco = p - t
        imp = 0
        pos = 0
        for i in range(len(n)):
            if (troco == n[i]):
                
                v = True
                 
        if v == True:
            print('possible')
        else:
            print('impossible')
    
    except:
        if p == 0 or t == 0:
            break