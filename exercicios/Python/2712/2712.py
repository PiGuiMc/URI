n =  int(input())

for i in range(n):
    placa = input()

    lplaca = placa[0:4]
    nPlaca = placa[4:8]

    teste = lplaca[0:3]
    v_teste = any(char.isdigit() for char in teste)

    
    #print(digit)

    if len(lplaca) == 4 and len(placa) == 8 and lplaca == lplaca.upper() and placa[3] == '-' and len(nPlaca) == 4 and v_teste != True:

            digit = int(placa[7])
            if (digit == 1 or digit == 2):
                    print("MONDAY")
            elif digit == 3 or digit == 4:
                    print("TUESDAY")
            elif digit == 5 or digit == 6:
                    print("WEDNESDAY")
            elif digit == 7 or digit == 8:
                    print("THURSDAY")
            else: print("FRIDAY")

    else:
        print('FAILURE')