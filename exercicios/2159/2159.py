import math

n = int(input())

pi = 3.1416

menor = n / math.log(n)
maior = 1.25506 * (n / math.log(n))

print('{:.1f} {:.1f}'.format(menor,maior))