def entrada():
    n = int(input())
    return n

def separacao(n):

    unidade = n % 10

    n //= 10

    dezena = n % 10

    n //= 10

    centena = n % 10

    return unidade, dezena, centena

def romanos(unidade, dezena, centena):
    roma = ''

    if centena > 0:
        #centena
        if centena <= 3:
            roma += 'C'*(centena)

        elif centena == 4:
            roma += 'CD'
        
        elif centena == 5:
            roma += 'D'
        
        elif centena > 5 and centena < 9:
            roma += 'D' + 'C'*(centena -5)
        
        elif centena == 9:
            roma +='CM'

    if dezena > 0:
        #dezena
        if dezena <= 3:
            roma += 'X'*(dezena)
            
        elif dezena == 4:
            roma += 'XL'
            
        elif dezena == 5:
            roma += 'L'
            
        elif dezena > 5 and dezena < 9:
            roma += 'L' + 'X'* (dezena - 5)
            
        elif dezena == 9:
            roma += 'XC'
        
    if unidade > 0:
        #unidade
        if unidade <= 3:
            roma += 'I'*(unidade)
            
        elif unidade == 4:
            roma +='IV'
            
        elif unidade == 5:
            roma += 'V'
            
        elif unidade > 5 and unidade < 9:
            roma += 'V' + 'I'*(unidade - 5)
            
        elif unidade == 9:
            roma += 'IX'
    return roma

def main():
    centena,dezena,unidade = separacao(entrada())
    print(romanos(centena,dezena,unidade))

main()