qt = int(input())

if qt >= 1 and qt <= 100:
    for i in range(qt):
        entrada = input().split()
        j1 = entrada[0]
        op1 = entrada[1]
        j2 = entrada[2]
        op2 = entrada[3]

        vl = input().split()
        v1 = int(vl[0])
        v2 = int(vl[1])
        if v1 >= 1 and v1 <= 1000000000 and v2 >= 1 and v2 <= 1000000000:
            
            if (v1 + v2) % 2 == 0:
                if op1 == 'PAR':
                    print(j1)
                else:
                    print(j2)
            if (v1 + v2) % 2 != 0:
                if op1 == 'IMPAR':
                    print(j1)
                else:
                    print(j2)

