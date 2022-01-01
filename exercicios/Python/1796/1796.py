n = int(input())

o = [int(x) for x in input().split()]

qt = o.count(0)

if qt > (n - qt):
    print('Y')
else:
    print('N')

'''
5
1 1 1 1 1

4
1 1 0 0
'''