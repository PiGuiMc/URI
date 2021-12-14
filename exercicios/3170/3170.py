import math

b = int(input())
g = int(input())

qt_b = g / 2

total = qt_b - b

if total > 0:
    print('Faltam {:.0f} bolinha(s)'.format(math.floor(total)))

else:
    print('Amelia tem todas bolinhas!')