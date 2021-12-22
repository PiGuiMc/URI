n = int(input())

ag = 0
bg = 0
emp = 0
for i in range(n):
    a,b = map(int,input().split())

    if a == b:
        emp += 1
    elif a > b:
        ag += 1
    
    elif b > a:
        bg += 1

print(ag,bg)
