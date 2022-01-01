n = int(input())


for i in range(n):
    i+=1
    op = input()
    r,g,b = map(int,input().split())
    '''35 70 35'''
    if op == 'eye':
        p = ((0.30 * r) + (0.59 * g) + (0.11 * b))
        print('Caso #{}: {}'.format(i,int(p)))
    
    elif op == 'min':
        list = [r,g,b]
    
        print('Caso #{}: {}'.format(i,min(list)))
    
    elif op == 'max':
        list = [r,g,b]
    
        print('Caso #{}: {}'.format(i,max(list)))
    
    elif op == 'mean':
        p = (r + g + b) /3
        print('Caso #{}: {}'.format(i,int(p)))
