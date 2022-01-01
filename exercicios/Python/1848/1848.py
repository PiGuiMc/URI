c = 0
s = 0 

while s != 3:
    for i in range(1000):
        n = input()
        if n == 'caw caw':
            s = s + 1
            print(c)
            c = 0

        if n == '---':
            c = c + 0
        
        if n == '--*':
            c = c + 1
        
        if n == '-*-':
            c = c + 2

        if n == '-**':
            c = c + 3

        if n == '*--':
            c = c + 4

        if n == '*-*':
            c = c + 5
        
        if n == '**-':
            c = c + 6
        
        if n == '***':
            c = c + 7       

        if s == 3:
            break


"""def piscada_bin(piscada):
    piscada = piscada.replace('-','0')
    piscada = piscada.replace('*','1')
    return piscada


def bin_int(piscada):
    piscada = int(piscada,2)
    return piscada


def soma(piscada,s):
    s += piscada
    return s

def main():
    for i in range(3):
        s = 0
        while True:
            piscada = input()
            if piscada != 'caw caw':
                piscada = piscada_bin(piscada)
                piscada = bin_int(piscada)
                s = soma(piscada,s)
            else:
                print(s)
                break

main()
    """