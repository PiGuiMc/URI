input = file('stdin','r')

a = as.integer(readLines(input,n=1))

if(a == 61){
    write(sprintf("Brasilia"),'')
}else if(a == 71){
    write(sprintf("Salvador"),'')
}else if(a == 11){
    write(sprintf("Sao Paulo"),'')
}else if(a == 21){
    write(sprintf("Rio de Janeiro"),'')
}else if(a == 32){
    write(sprintf("Juiz de Fora"),'')
}else if(a == 19){
    write(sprintf("Campinas"),'')
}else if(a == 27){
    write(sprintf("Vitoria"),'')
}else if(a == 31){
    write(sprintf("Belo Horizonte"),'')
}else{
    write(sprintf("DDD nao cadastrado"),'')
}