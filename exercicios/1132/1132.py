soma = 0
v = int(input())
v2 = int(input())

if v2>v:
    for n in range(v,(v2+1)):
        if(n%13 != 0):
            soma += n

if v > v2:
    for n in range(v2,(v+1)):
        if n%13 != 0:
            soma += n

print(soma)
