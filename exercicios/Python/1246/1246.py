while True:
    try:
        cars = []
        cont,saiu = 0,0
        tam,n = map(int,(input().split()))

        for i in range(n):
            entrada = input()
            cars.append(entrada)
            op = entrada.split()[0]
            placa = entrada.split()[1]
            if op == 'C':
                tamanho = int(entrada.split()[2])

            if op == 'C' and tamanho <= tam:
                cont += 1
            
            elif op == 'S':
                if '{} {}'.format(op,placa) in cars:
                    saiu += 1
                    cars.remove('{} {}'.format(op,placa))
            
        print(saiu)


    
    except EOFError:
        break