n = str(input())

tam = len(n)

val = '00'
um = '1'

zero = n.rfind(val)
nUm = n.rfind(um,0)
print(tam)
if zero % 2 == 0:
    q = zero / 2
else:
    q = zero - 1

if nUm == tam - 1:
    q = 0
    print('aqiuo')

#print('{:.0F}'.format(q))