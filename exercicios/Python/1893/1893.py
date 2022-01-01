ini, fim = map(int,(input().split()))

if ini >= 0 and fim <= 2:
    print('nova')

elif fim >= 97 and fim <= 100:
    print('cheia')

elif (fim > ini):
    print('crescente')
else:
    print('minguante')