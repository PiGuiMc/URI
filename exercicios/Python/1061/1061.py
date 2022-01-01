from typing import Sequence


dia_i = input().split()
h_i = input().split()
dia_f = input().split()
h_f = input().split()

di, df = int(dia_i[1]), int(dia_f[1])
hi,mi,si = int(h_i[0]),int(h_i[2]),int(h_i[4])
hf,mf,sf = int(h_f[0]),int(h_f[2]),int(h_f[4])

seg_min =  60
hr = seg_min * 60
dia = hr * 24

ini = si + mi * seg_min + hi * hr + di * dia
fim = sf + mf * seg_min + hf * hr + df * dia

if ini < fim:
    tempo = fim - ini
    dias = int(tempo/dia)
    tempo = tempo%dia
    horas = int(tempo/hr)
    tempo = tempo%hr
    minutos = int(tempo/seg_min)
    tempo = tempo%seg_min
    segundos = tempo
    print('{} dia(s)\n{} hora(s)\n{} minuto(s)\n{} segundo(s)'.format(dias, horas, minutos, segundos))