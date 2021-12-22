ag = 0
bg = 0
emp = 0

while True:
    n = int(input())

    if n == 0:
        break

    for i in range(n):
        a,b = map(int,input().split())

        if a == b:
            emp += 1
        elif a > b:
            ag += 1
        
        elif b > a:
            bg += 1
 
    print(ag,bg)
    ag,bg,emp =0,0,0
