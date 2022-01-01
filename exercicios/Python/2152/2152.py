def main():
    n = int(input())
    h,m,o = 0,0,0
    for i in range(n):
        v = input().split()
        h = int(v[0])
        m = int(v[1])
        o = int(v[2])

        if o == 1:
            if h < 10 and m < 10:
                print('0{}:0{} - A porta abriu!'.format(h,m))
            
            elif h < 10 and m >= 10:
                print('0{}:{} - A porta abriu!'.format(h,m))
            
            elif h >= 10 and m < 10:
                print('{}:0{} - A porta abriu!'.format(h,m))
            
            elif h >= 10 and m >= 10:
                print('{}:{} - A porta abriu!'.format(h,m))
        
        if o == 0:
            if h < 10 and m < 10:
                print('0{}:0{} - A porta fechou!'.format(h,m))
            
            elif h < 10 and m >= 10:
                print('0{}:{} - A porta fechou!'.format(h,m))
            
            elif h >= 10 and m < 10:
                print('{}:0{} - A porta fechou!'.format(h,m))

            elif h >= 10 and m >= 10:
                print('{}:{} - A porta fechou!'.format(h,m))
    
main()