n1 = float(input())
n2 = float(input())
n3 = float(input())
n4 = float(input())
n5 = float(input())
n6 = float(input())

p = 0;
m = 0;

v =[n1,n2,n3,n4,n5,n6]

for n in v:
    if n > 0:
        p = p + 1;
        m = m + (n)

print('{} valores positivos'.format(p))
print('{:.1f}'.format(m/p))
