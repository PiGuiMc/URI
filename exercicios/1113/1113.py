a = 100
b = 1000

while a != b:
    a,b = map(int,input().split())

    asc = 'Crescente'
    desc = 'Decrescente'

    if a < b:
        print(asc)
    if a > b:
        print(desc)
    if a == b:
        print('')
