import math

vl = input().split()

A = float(vl[0])
B = float(vl[1])
C = float(vl[2])

delta = B**2 - 4*(A*C) 

div = 2 * A
if (div == 0) or (delta < 0):
    print("Impossivel calcular")
else:
    R1 = float((-B + math.sqrt(delta)) / (div))

    R2 = float((-B - math.sqrt(delta)) / (div))

    print("R1 = {:.5f}".format(R1))
    print("R2 = {:.5f}".format(R2))