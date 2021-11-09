entrada = input().split()

a = float(entrada[0])
b = float(entrada[1])
c = float(entrada[2])

if abs(b - c) < a < (b + c) and (a - c) < b < (a + c) and (a - b) < c < (a + b):
    print('Perimetro = {:.1F}'.format(a + b + c))
else:
    print('Area = {:1F}'.format(((a+b)/2)*c))
   