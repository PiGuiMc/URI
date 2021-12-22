
while True:

        t,n = map(int,input().split())
        
        totalPonto = 3 * n
        empate = 0

        if t == 0 and n == 0:
            break

        for i in range(t):
            entrada= (input().split())
            time = str(entrada[0])
            ponto = int(entrada[1])

            empate += ponto


        print(totalPonto - empate)
