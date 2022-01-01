def entrada():
    vl = 0
    x = int(input())

    for i in range(x):
        v =  input().split()
        cod = int(v[0])
        qt = int(v[1])

        if cod == 1001:
            vl = vl + 1.5 * qt
        elif cod == 1002:
            vl = vl + 2.5 * qt
        elif cod == 1003:
            vl = vl + 3.5 * qt
        elif cod == 1004:
            vl = vl + 4.5 * qt
        elif cod == 1005:
            vl = vl + 5.5 * qt

    return(vl)

def main():
    vl = entrada()
    print('{:.2F}'.format(vl))
main()