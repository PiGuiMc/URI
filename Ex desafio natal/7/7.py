nomes = []
presente = []
prioridade = []
teste = []
n = int(input())

for i in range(n):
    entrada = input().split()
    nome = str(entrada[0])
    pres = str(entrada[1])
    p = int(entrada[2])

    nomes.append(nome)
    presente.append(pres)
    prioridade.append(p)

    teste = sorted(prioridade)

for i in range(len(prioridade)):
                        
    if teste[i] in prioridade:
        n_pos = prioridade.index(teste[i])
        print(nomes[n_pos],presente[n_pos],teste[i])
