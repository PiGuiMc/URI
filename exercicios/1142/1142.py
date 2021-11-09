n = int(input())
x = 1
for i in range(1, n + 1):
    print('{} {} {}'.format(x,x*x, x*x))
    
    x = x + 1
    print('{} {} {}'.format(x,x*2, x**3))