a = int(input())
b = int(input())
c = int(input())

if a >= -10000 and a <= 10000 and b >= 0 and b <= 99 and c >=0 and c <= 999:
    #5
    print('A = {}, B = {}, C = {}'.format(a,b,c))

    #6
    print('A = {: >10}, B = {: >10}, C = {: >10}'.format(a,b,c))
    
    #7
    if a < 0 and b > 0 and c > 0:
        new = str(a)
        new = new.replace('-','')
        print('A = -{:0>9}, B = {:0>10}, C = {:0>10}'.format(new,b,c))

    else:
        a = a
        print('A = {:0>10}, B = {:0>10}, C = {:0>10}'.format(a,b,c))

    #8
    print('A = {: <10}, B = {: <10}, C = {: <10}'.format(a,b,c))
