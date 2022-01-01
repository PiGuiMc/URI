dist = 0
i = 0

while True:
    
    try:
        nome = input()
        m = int(input())

        dist += m
        i += 1

        media = dist / i

    except EOFError:
        print('{:.1f}'.format(media))
        break