while True:
    n = input().split()
    if n == 0:
        break
    if n != 0:
        a = int(n[0])
        b = int(n[1])
        c = int(n[2])
    
    area = a * b
    total = (area * (c * 100))
    print(total)
    
