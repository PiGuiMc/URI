n = int(input())
r = 0;

for i in range(1 , n + 1):
    x = input().split()
    a,b = x
    s = 0
    a = int(a)
    b = int(b)
    
    if a > b:
        for r in range(int(b) + 1, int(a)):
            if r % 2 != 0:
                s = s + r
    if a < b:
        for r in range(int(a) + 1, int(b)):
            if r % 2 != 0:
                s = s + r
    if a == b:
        s = 0
    print(s)