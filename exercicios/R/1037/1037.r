input = file('stdin','r')

valor = as.double(readLines(input,n=1))
if(valor >= 0 & valor <= 25){
    write(sprintf("Intervalo [0,25]"),'')
}
if(valor > 25 & valor <= 50){
    write(sprintf("Intervalo (25,50]"),'')
}
if(valor > 50 & valor <= 75){
    write(sprintf("Intervalo (50,75]"),'')
}
if(valor > 75 & valor <= 100){
    write(sprintf("Intervalo (75,100]"),'')
}
if (valor < 0 | valor > 100){
    write(sprintf("Fora de intervalo"),'')
}
