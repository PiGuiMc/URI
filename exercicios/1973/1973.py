n = int(input())

t = input()
t = map(int,t.split())

pos, soma, total = 0,0,0

continua = True

for i, num in enumerate(t):
    total+=num
    
    if (num % 2 == 0 and continua):
        ataques = i+1
        soma += ((i*2) -1) - pos
        continua = False

    if(num - 1 == 0 and continua):
        pos = i + 1
else:
    if (soma > 0):
        total -= soma
    else:
        ataques = n
        total -= ataques
    
print("%d %d"%(ataques,total))