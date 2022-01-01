n = input().split()

a = int(n[0])
b = int(n[1])
c = int(n[2])
d = int(n[3])

if 1 <= a and a <= 100 and 1 <= b and b <= 100 and 1 <= c and c <= 100 and 1 <= d and d <= 100: 
    if a + b > c and b + c > a and a + c > b:
        print('S')
    elif b + c > d and c + d > b and b + d > c: 
        print('S')
    elif a + c > d and c + d >a and a + d > c:
        print('S')
    elif a + b> d and b + d > a and a + d > b:
        print('S')
    else:
        print('N')