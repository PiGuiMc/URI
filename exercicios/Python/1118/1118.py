i = 0
med = 0
novo = 0
new = True
while new == True:
    while i < 2:
        nota = float(input())
        if nota >= 0 and nota <= 10:
            i = i + 1
            med = med + nota
        if nota < 0 or nota > 10:
            print('nota invalida')
    med = med / 2
    print('media = {:.2f}'.format(med))

    if i == 2:
        i = 0
        med = 0
        
    while True:
            print("novo calculo (1-sim 2-nao)")
            novo = int(input())
            if novo == 2:
                new = False
                break
            elif novo == 1:
                new = True
                break
