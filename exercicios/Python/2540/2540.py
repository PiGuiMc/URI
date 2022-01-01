while True:
    dados = []
    count1 = 0
    count0 = 0
    try:
        n = int(input())
        
        e = input()
        dados = e

        for i in range(len(dados)):
            if dados[i] == '1':
                count1 += 1
            elif dados[i] == '0':
                count0 += 1

        if ((count1 * 100) / n) > 60:
            print('impeachment')
        else:
            print('acusacao arquivada')
   
    except EOFError:
        break