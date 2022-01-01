def entrada():
    n = int(input())
    return(n)

def main():

    n = entrada()
    for i in range(n):
        v = int(input())
        if v % 2 == 0:
            print(0)
        else:
            print(1)
        i += 1

main()