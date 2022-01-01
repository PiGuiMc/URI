A = []
for i in range(100):
    n = float(input())
    A.append(n)
    if n <= 10.0:
        print('A[{}] = {}'.format(i,n))
