a = 0
b = 0
k = 0
n,t,l = map(int,input().split())

for i in range(n-1):
    s = int(input())

    if abs(t - s) <= l:
        if k == 0:
            a += abs(t - s)
        else:
            b += abs(t - s)
        
        t = s
    
    if k == 0:
        k = 1
    else:
        k = 0
print(a,b)
