def entrada():
    n = input().split()
    return n

def valores(n):
    p1 = float(n[0])
    p2 = float(n[1])

    reajuste = ((p2 * 100) / p1) - 100

    return reajuste

def main():
    reajuste = entrada()
    print('{:.2F}%'.format(valores(reajuste)))
main()