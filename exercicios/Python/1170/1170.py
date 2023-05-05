v = int(input())

for i in range(v):
    qt = float(input())

    dia = 0
    while(True):

        qt = qt / 2
        dia += 1

        if(qt <= 1):
            break
    
    print(f'{dia} dias')