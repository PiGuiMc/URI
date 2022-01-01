n = int(input())
p = 'eh perfeito'
pn = 'nao eh perfeito'

for i in range(1,n + 1):
    num = int(input())
    s = 0
    j = 1
    
    while j < num:
        if num % j == 0:
            s = s + j

        j = j + 1
    if s == num:
        print(num,p)
    else:
        print(num,pn)
