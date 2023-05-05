n = int(input())

for i in range(n):
    p_j, p_m = 0,0
    for j in range(6):
        ent = input().split()
        x = int(ent[0])
        d = int(ent[1])
        if(j < 3):
            p_j += x * d
        elif(j > 2):
            p_m += x * d
    
    print('JOAO') if p_j >= p_m else print('MARIA')
