n = int(input())

for i in range(0, n):
    x = input().split()

    pa = int(x[0])
    pb = int(x[1])
    g1 = float(x[2])/100
    g2 = float(x[3])/100
    anos = 0
    while True:
        pa += int(pa * g1)
        pb += int(pb * g2)
        anos += 1

        if pa > pb or anos > 100:
            break

    if anos <= 100:
        print(anos,'anos.')
    else:
        print('Mais de 1 seculo.')