while True:
    n = input().split()
    if n == 0:
        break
    if n != 0:
        a = int(n[0])
        b = int(n[1])
        c = int(n[2])
    
    area = a * b
    areac = 8 * 8
    porc = c / 100
    total = ((area - areac) * porc)
    print(total)
    
