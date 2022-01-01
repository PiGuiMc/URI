while True:
    v = input().split()
    n = int(v[0])
    exp = int(v[1])

    if n == 0 and exp == 0:
        break
    else:
        print(exp * n)
