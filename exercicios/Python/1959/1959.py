def entrada():
    v = input().split()
    n = int(v[0])
    l = int(v[1])
    return(n,l)

def main():
    n,l = entrada()

    p = n * l

    print(p)

main()
