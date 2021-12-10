n = int(input())

t1,t2 = map(int,input().split())

if t1 + t2 <= n:
    print('Farei hoje!')
else:
    print('Deixa para amanha!')