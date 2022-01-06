input = file('stdin','r')

qt_c = 0
qt_m = 0.0

valor = as.double(readLines(input, n=1))

notas <- c(100, 50, 20, 10, 5, 2)
moedas <- as.double(c(1.00, 0.50, 0.25, 0.10, 0.05, 0.01))

write(sprintf("NOTAS:"),'')
for(i in notas){
    qt_c = as.integer(valor / i)

    write(sprintf("%d nota(s) de R$ %d.00",qt_c,i),'')
    valor = valor - (qt_c * i)
}

write(sprintf("MOEDAS:"),'')
for(i in moedas){
    qt_m = as.integer((valor+0.0001) / i)

    write(sprintf("%d moeda(s) de R$ %.2f",qt_m,i),'')
    valor = valor - (qt_m * i)
}