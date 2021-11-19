v = int(input())
n = []
j = 0
i = 0   

for i in range (1000):
    print('N[{}] = {}'.format(i,j))
       

    j = j + 1
    i = i + 1
    if j == v:
        j = 0
    if i == 1000:
        break