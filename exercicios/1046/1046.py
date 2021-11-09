x = input().split()

a = int(x[0])
b = int(x[1])

dia = 24;

if((a >= b)):
    x1 = dia - ( a - b)
    print("O JOGO DUROU", x1," HORA(S)")

elif(a <= b):
    x1 = (b - a)
    print("O JOGO DUROU", x1,"HORA(S)")
elif(a == b) <= dia:
    print("O JOGO DUROU 24 HORA(S)")