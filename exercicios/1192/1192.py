n = int(input())

for i in range(n):
    ent = input()

    n1 = int(ent[0:1])
    n2 = int(ent[2:3])
    op = ent[1:2]

    if n1 == n2:
        result = n1 * n2
    
    elif op.isupper():
        result = n2 - n1
    
    elif op.islower():
        result = n1 + n2
    
    print(result)