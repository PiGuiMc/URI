v = input().split()

a = int(v[0])
b = int(v[1])
c = int(v[2])

if((a-b == 0) or (a-c == 0) or (b-c == 0)):
    print('S')
else:
    if((a+b-c == 0) or (b-a+c == 0) or (c-a+b == 0)):
        print('S')
    elif((a-b-c == 0) or (b-a-c == 0) or (c-a-b == 0)):
        print('S')
    else:
        print('N')