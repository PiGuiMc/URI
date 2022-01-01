def entrada():
    n = input().split()
    s = int(n[0])
    t = int(n[1])
    f = float(n[2])
    return(s,t,f)

def main():
    s,t,f = entrada()
    ht = 0
    
    ht = s + t + f

    if ht == 24:
        ht = 0

    elif ht > 24:
        ht = ht - 24
    elif ht < 0:
        ht = ht + 24
    print('{:.0F}'.format(ht))

main()