def entrada():
    n = int(input())
    return(n)

def main():
    n = entrada()
    ArrAluno = []
    ArrNota=[]
    cont = 0
    aux = 0
    pos = 0

    for i in range(n):
        aluno, nota = input().split()
        aluno = int(aluno)
        nota = float(nota)

        if nota >= 8:
            ArrAluno.append(int(aluno))
            ArrNota.append(float(nota))
    
    for x in ArrAluno:
        if x > aux:
            aux = x
            pos = x
    if pos == 0:
        print('Minimum note not reached')
    else:
        print(pos)
main()
