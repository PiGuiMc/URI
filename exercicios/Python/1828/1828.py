x = int(input())
i = 0

for i in range(1,x + 1):
    v = input().split()
    v1 = v[0]
    v2 = v[1]
    

    r1 = 'Caso #{}: Bazinga!'.format(i)
    r2 = 'Caso #{}: Raj trapaceou!'.format(i)
    r3 = 'Caso #{}: De novo!'.format(i)

    if v1 != '' and v2 != '':

        if v1 == 'tesoura' and v2 == 'papel':
            print(r1)
        elif v1 == 'papel' and v2 == 'tesoura':
            print(r2)

        if v1 == 'papel' and v2 == 'pedra':
            print(r1)
        elif v1 == 'pedra' and v2 == 'papel':
            print(r2)

        if v1 == 'pedra' and v2 == 'lagarto':
            print(r1)
        elif v1 == 'lagarto' and v2 == 'pedra':
            print(r2)

        if v1 == 'lagarto' and v2 == 'Spock':
            print(r1)
        elif v1 == 'Spock' and v2 == 'lagarto':
            print(r2)

        if v1 == 'Spock' and v2 == 'tesoura':
            print(r1)
        elif v1 == 'tesoura' and v2 == 'Spock':
            print(r2)
        
        if v1 == 'tesoura' and v2 == 'lagarto':
            print(r1)
        elif v1 == 'lagarto' and v2 == 'tesoura':
            print(r2)
        
        if v1 == 'lagarto' and v2 == 'papel':
            print(r1)
        elif v1 == 'papel' and v2 == 'lagarto':
            print(r2)
        
        if v1 == 'papel' and v2 == 'Spock':
            print(r1)
        elif v1 == 'Spock' and v2 == 'papel':
            print(r2)

        if v1 == 'Spock' and v2 == 'pedra':
            print(r1)
        elif v1 == 'pedra' and v2 == 'Spock':
            print(r2)

        if v1 == 'pedra' and v2 == 'tesoura':
            print(r1)
        elif v1 == 'tesoura' and v2 == 'pedra':
            print(r2)
        
        
        if v1 == v2:
            print(r3)
        i = i + 1
