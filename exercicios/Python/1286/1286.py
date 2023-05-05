import operator

n = int(input())

while(n != 0):
    p = int(input())

    t = {}
    qt = 0
    for i in range(n):
        v = input().split()

        t[int(v[0])] = int(v[1])
        print(t)
    sortedDIc  = sorted(t.items(), key=operator.itemgetter(0))
    print(t[15])
    print(sortedDIc)