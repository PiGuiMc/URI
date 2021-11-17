while True:
    i = 1
    soma = 0
    n = int(input())
    if n == 0:
        break
    if n != 0:
        while i <= 5:
            if n % 2 == 0:
                soma = soma + n
                n = n + 1
                i = i+ 1
            else:
                n = n + 1

    
        print(soma)    
    