vl = input().split()

a = int(vl[0])
b = int(vl[1])
c = int(vl[2])
d = int(vl[3])

if(b > c) and (d > a) and (c + d > a + b) and (c > 0) and (d > 0):
    print("Valores Aceitos")
else: print("Valores não aceitos")