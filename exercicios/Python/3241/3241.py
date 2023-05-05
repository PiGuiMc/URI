v = int(input())

for i in range(v):
    op = input()
    
    if(op == 'P=NP'):
        print('skipped')

    elif(op.find('+') >= 0):
        x = op.find('+')
        v1 = op

        min1 = (v1[0:x])
        min2 = (v1[x+1:len(op)])

        while(len(min1) < len(min2)):
            min1 = '0' + min1
        while(len(min2) < len(min1)):
            min2 = '0' + min2

        soma = int(min1) + int(min2)

        print(soma)