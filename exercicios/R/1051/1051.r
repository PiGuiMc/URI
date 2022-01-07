input = file('stdin','r')

Valor = as.double(readLines(input,n=1))

if(Valor >= 0 && Valor <= 2000){
    write(sprintf("Isento"),'')
}else if(Valor >= 2000.01 && Valor <= 3000){
    vimp = as.double((Valor - 2000) * 0.08)
    write(sprintf("R$ %.2f",vimp),'')
}else if(Valor >= 3000.01 && Valor <= 4500){
    i8 = as.double(0.08 * 1000)
    i18 = as.double(Valor - 3000)
    vimp = as.double(i18 * 0.18) + i8
    write(sprintf("R$ %.2f",vimp),'')
}else if(Valor >= 4500.01){
    i8 = as.double(0.08* 1000)
    i18 = as.double(0.18 * 1500)
    i28 = as.double(Valor - 4500)
    vimp = as.double(i18 + i8 + (i28 * 0.28))
    write(sprintf("R$ %.2f",vimp),'')
}