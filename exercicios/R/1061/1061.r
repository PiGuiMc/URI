input = file('stdin','r')

dia1 = strsplit(readLines(input, n=1), " ")
data1 = as.integer(dia1[[1]][2])

tempo1 = strsplit(readLines(input, n=1), " ")
hora1 = as.integer(tempo1[[1]][1])
min1 = as.integer(tempo1[[1]][3])
seg1 = as.integer(tempo1[[1]][5])

dia2 = strsplit(readLines(input,n=1), " ")
data2 = as.integer(dia2[[1]][2])

tempo2 = strsplit(readLines(input,n=1), " ")
hora2 = as.integer(tempo2[[1]][1])
min2 = as.integer(tempo2[[1]][3])
seg2 = as.integer(tempo2[[1]][5])

minuto_seg = as.integer(60)
hora_seg = as.integer(3600)
dia_seg = as.integer(3600 * 24)

tempo_1 = as.integer(seg1 + min1*minuto_seg + hora1*hora_seg + data1*dia_seg)
tempo_2 = as.integer(seg2 + min2*minuto_seg + hora2*hora_seg + data2*dia_seg)

if (tempo_1 < tempo_2){
    tempo = tempo_2 - tempo_1;
    dias = as.integer(tempo/dia_seg);

    tempo = tempo%%dia_seg;
    horas = as.integer(tempo/hora_seg);

    tempo = tempo%%hora_seg;
    minutos = as.integer(tempo/minuto_seg);
                
    tempo = tempo%% minuto_seg;
    segundos = tempo;

    write(sprintf("%d dia(s)",dias),'')
    write(sprintf("%d hora(s)",horas),'')
    write(sprintf("%d minuto(s)",minutos),'')
    write(sprintf("%d segundo(s)",segundos),'')
}