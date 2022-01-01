frango, bife, massa = map(int,input().split())

"""frango = int(frango)
bife = int(bife)
massa = int(massa)"""

pFrango, pBife, pMassa = map(int,input().split())

"""pFrango = int(pFrango)
pBife = int(pBife)
pMassa = int(pMassa)
"""
total = 0

if pFrango > frango:
    total +=  pFrango - frango 

if pBife > bife:
    total +=  pBife - bife

if pMassa > massa:
    total +=  pMassa - massa

if pFrango == frango and pMassa == massa and pBife == bife:
    total = 0

print(total)