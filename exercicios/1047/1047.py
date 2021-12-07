x = input().split()

h_ini = int(x[0])
m_ini = int(x[1])
h_fim = int(x[2])
m_fim = int(x[3])

dia = 24
hora = 60

if(h_ini == h_fim) and (m_ini == m_fim):
    m = 0
    print('O JOGO DUROU {:.0F}'.format(dia),'HORA(S) E {:.0F}'.format(m),'MINUTO(S)')

elif(h_ini <= h_fim) and (m_ini <= m_fim):
    h = (h_fim - h_ini)
    m = (m_fim - m_ini)
    print('O JOGO DUROU {:.0F}'.format(h),'HORA(S) E {:.0F}'.format(m),'MINUTO(S)')

elif(h_ini <= h_fim) and m_ini >= m_fim:
    if(h_fim - h_ini) > 0 and m_ini >= m_fim:
        h = 0
        m =   hora - (m_ini - m_fim)
        print('O JOGO DUROU {:.0F}'.format(h),'HORA(S) E {:.0F}'.format(m),'MINUTO(S)')
    
    elif (h_fim - h_ini) == 0 and (m_ini >= m_fim):
        h = 23
        m = 60 - (m_ini - m_fim)
        print('O JOGO DUROU {:.0F}'.format(h),'HORA(S) E {:.0F}'.format(m),'MINUTO(S)')

elif(h_ini >= h_fim) and m_ini >= m_fim:
    if(h_fim - h_ini) > 0 and m_ini >= m_fim:
        h = 0
        m =   hora - (m_ini - m_fim)
        print('O JOGO DUROU {:.0F}'.format(h),'HORA(S) E {:.0F}'.format(m),'MINUTO(S)')
