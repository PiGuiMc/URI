x = int(input())
z = x - 1
i = 2
S = 1
soma = x
while z <= x:
    z = int(input())
while soma <= z:
    soma = soma + x + S
    
    if soma <= z:
        i = i + 1
        S = S + 1
print(i)
