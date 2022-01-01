descDia = {0:'DOM', 1:'SEG', 2:'TER',3:'QUA',4:'QUI',5:'SEX',6:'SAB'}
nMes = ''
cont = 0
while True:
    i,nMin,nSeg,nHora,nDia,nAno,aux = 0,0,0,0,0,0,0
    nDescData = ''
    min = 60
    hora = 3600
    dia = hora * 24
    entrada = input()

    if entrada == 'FIM':
        break
    
    desD = entrada[0:3]
    diaData = int(entrada[4:6])
    mesData = entrada[6:9]
    anoData = int(entrada[9:13])
    horaData = int(entrada[14:16])
    minData = int(entrada[17:19])
    segData = int(entrada[20:22])

    cont +=1
    print('Previsao #{}'.format(cont))

    while True:
        segEnt = int(input())
        
        nMin = ((segEnt / 60) - ((segEnt / 60) % 1))
        nSeg = (((segEnt / 60) % 1) * 60)
   
        if nSeg + segData < 60:
            nSeg += segData
        elif nSeg + segData >= 60:
            aux = nSeg + segData - 60
            nSeg = aux
        if nMin + minData < 60:
            nMin += minData
        elif nMin + minData >= 60:
            aux = nMin + minData
            nMin = (((aux * 60) / 3600) % 1 ) * 60
            nHora = (aux * 60) / 3600

        if nHora + horaData >= 0 and nHora + horaData < 24:
            nHora += horaData
            print('a')
        elif nHora + horaData >= 24:
            if nHora + horaData == 24:
                nHora = horaData
                nDia = diaData + 1
                nDescData =  descDia[nDia - diaData]
    
                print('b')
            elif nHora + horaData > 24:
                nHora = ((segEnt) / 86400)
                if nHora == 1:
                    nHora = horaData
                else:
                    nHora =  (nHora + horaData) - 1
                nDia = round(diaData + (segEnt / 86400))
                nDescData =  descDia[nDia - diaData]
                print('c')

        nMes = mesData
        nAno = anoData
        print('{},{}{}{}:{}:{}:{}'.format(nDescData,nDia,nMes,nAno,round(nHora),round(nMin),round(nSeg)))
        i+=1
        nMin,nSeg,nHora = 0,0,0