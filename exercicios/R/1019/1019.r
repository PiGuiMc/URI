input = file('stdin','r')

valor = as.integer(readLines(input, n=1))
hora =0
min =0
seg =0
if(valor >= 3600){
    hora = as.integer(valor / 3600)
    valor = valor - (hora * 3600)
}
if(valor >= 60 & valor < 3600){
    min = as.integer(valor / 60)
    valor = valor - ( min * 60)
}
if(valor < 60){
    seg = valor
}
write(sprintf("%d:%d:%d",hora,min,seg),'')