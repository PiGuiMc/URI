m,j = 0,0

while True:
    try:
        n = int(input())

        lista = [int(x) for x in input().split()]

        for i in range(n):

            if lista[i] == 0:
                m += 1
            else:
                j += 1

        print('Mary won {} times and John won {} times'.format(m,j))
        m,j = 0,0
    except EOFError:
        break
