n = input().split()

o = float(n[0])
b = float(n[1])
i = float(n[2])

if o < b and o < i:
    print("Otavio")

elif b < o and b < i:
    print('Bruno')

elif i < b and i < o:
    print('Ian')

elif o == i or o == b or b == i:
    print('Empate')