def contador(n):
    contagem = len(n)
    return contagem
n = str(input())

def main():
    num = 0
    aux = int(contador(n))

    for i in range(aux+1):
        if i == aux:
            num1 = (aux - (i + 1))
            num = int(n[:num1])
            print(num)

            mul = int(n[aux-1])
            print('aqui')
            print(mul)

            total = num + mul * 5
            print(total)

main()