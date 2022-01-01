x = input().split()

a = int(x[0])
b = int(x[1])

if a >= 1 and a <= 13 and b >= 1 and b <= 13:
    if a == b:
        print(a)
    elif a > b:
        print(a)
    elif a < b:
        print(b)