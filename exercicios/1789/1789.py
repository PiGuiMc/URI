while True:
    try:
        n = int(input())
        x = input().split()
        m = 0

        for i in range(n):
            if int(x[i]) > m:
                m = int(x[i])
        
        if m < 10:
            n = 1
        elif m >= 10 and m < 20:
            n = 2
        else:
            n = 3
        print(n)
    
    except EOFError:
        break