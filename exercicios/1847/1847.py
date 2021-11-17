a,b,c = map(int,input().split())

if a > b and a > c and b < c:
    print(':)')

elif a < b and b > c and a < c:
    print(':(')

elif a < b and b < c and a < c:
    print(':(')
