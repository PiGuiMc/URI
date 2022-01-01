x = int(input())

for i in range (1,x + 1):
    v = input().split()
    n = str(v[0])
    f = int(v[1])

    if n == 'Thor':
        print('Y')
    else:
        print('N')