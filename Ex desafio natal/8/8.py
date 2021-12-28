r = 0
c,w = map(int,input().split())

cidade = [str(c) for c in input().split()]

for i in range(w):
    entrada = input().split()
    cid1 = entrada[0]
    cid2 = entrada[1]
    ind1 = cidade.index(cid1)
    ind2 = cidade.index(cid2)

    if ind1 < ind2:
        r += 1
    else:
        r -=1


if r > 0:
    print('merry christmas')
else:
    print('no gifts today')
'''
danbury norwalk waterbury stamfort bridgeport trenton

danbury stamfort
bridgeport trenton
trenton danbury
waterbury trenton
stamfort norwalk
trenton norwalk
norwalk waterbury
norwalk bridgeport


danbury norwalk waterbury stamfort bridgeport trenton

danbury stamfort
bridgeport trenton
trenton danbury
waterbury trenton
stamfort norwalk
trenton norwalk
norwalk waterbury
norwalk danbury

'''