while True:
    try:
        n = int(input())

        if n >= 1001 and n <= 9999:
            print(n - 1)
        else:
            break
    except:
        break