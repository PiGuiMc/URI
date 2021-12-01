def entrada():

    n = int(input())

    return(n)

def main():
    n = entrada()
    g1 = 'Jogador 1 venceu'
    g2 = 'Jogador 2 venceu'
    for i in range(n):
        j1 = input()
        j2 = input()

        if j1 == 'ataque' and j2 == 'pedra':
            print(g1)
        elif j1 == 'pedra' and j2 == 'ataque':
            print(g2)

        elif j1 == 'pedra' and j2 == 'papel':
            print(g1)
        elif j1 == 'papel' and j2 == 'pedra':
            print(g2)
        
        elif j1 == 'ataque' and j2 == 'papel':
            print(g1)
        elif j1 == 'papel' and j2 == 'ataque':
            print(g2)
        
        elif j1 == 'papel' and j2 == 'papel':
            print('Ambos venceram')
        
        elif j1 == 'pedra' and j2 == 'pedra':
            print('Sem ganhador')
        
        elif j1 == 'ataque' and j2 == 'ataque':
            print('Aniquilacao mutua')

        i+=1
main()
