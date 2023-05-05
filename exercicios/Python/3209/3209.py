qt = int(input())

for i in range(qt):

    v = [int(x) for x in input().split()]
    total = 0

    for k in range(len(v)-1):
        k+=1

        if(k < len(v)-1):
            total += v[k] - 1
        if(k == len(v)-1 ):
            total += v[k]

    print(total)
