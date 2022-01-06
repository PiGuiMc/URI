input = file('stdin','r')
ano = 0
mes =0
dia =0
valor = as.integer(readLines(input, n=1))

if(valor >= 365){
    ano = as.integer(valor / 365)
    valor = valor - (ano * 365)
}
if(valor >= 30 & valor < 365){
    mes = as.integer(valor / 30)
    valor = valor - (mes * 30)
}
if( valor < 60){
    dia = valor
}
write(sprintf("%d ano(s)",ano),'')
write(sprintf("%d mes(es)",mes),'')
write(sprintf("%d dia(s)",dia),'')