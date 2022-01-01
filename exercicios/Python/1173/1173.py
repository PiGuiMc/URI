X=[1,2,3,4,5,6,7,8,9,10]
j = 0
k = 1
n = int(input())
i = 1
while i!=0:
    
    if j == 0:
        print('N[{}] = {}'.format(j,n))
    elif j!= 0:
        k = k * 2
        print('N[{}] = {}'.format(j,(n * k)))
    
    j += 1
    if j == 10:
        i = 0