entrada = input().split()

qt = 0

p = float(entrada[0])
c = int(entrada[1])
pt = float(entrada[2])

for i in range(c):
    op = float(input())
    qt += op

pf = qt + p

if pf <= pt:
    print('{:.2f}'.format(pf))
    print('ho ho ho')
if pf > pt:
    print('{:.2f}'.format(pf))
    print('papai noel precisa fazer exercicios')