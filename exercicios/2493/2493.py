expressao = []
while True:
    try:
        t = int(input())

        expressao = [int(t) for t in input().split()]

        for i in range(t):
            print(expressao[i])
    

    except EOFError:
        break