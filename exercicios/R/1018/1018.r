input = file('stdin','r')

qt100 = 0
qt50 = 0
qt20 = 0
qt10 = 0
qt5 = 0
qt2 = 0
qt1 = 0

valor = as.integer(readLines(input, n=1))
total = as.integer(valor)
if (valor >= 100){
    qt100 = as.integer(valor / 100)
    valor = valor - (qt100 * 100)
}

if (valor >= 50 & valor < 100){
    qt50 = as.integer(valor / 50)
    valor = valor - (qt50 * 50)
}

if (valor >= 20 & valor < 50){
    qt20 = as.integer(valor / 20)
    valor = valor - (qt20 * 20)
}

if (valor >= 10 & valor < 20){
    qt10 = as.integer(valor / 10)
    valor = valor - (qt10 * 10)
}

if (valor >= 5 & valor < 10){
    qt5 = as.integer(valor / 5)
    valor = valor - (qt5 * 5)
}

if (valor >= 2 & valor < 5){
    qt2 = as.integer(valor / 2)
    valor = valor - (qt2 * 2)
}
if (valor >= 1 & valor < 2){
    qt1 = as.integer(valor / 1)
    valor = valor - (qt1 * 1)
}

write(sprintf("%d",total), '')
write(sprintf("%d nota(s) de R$ 100,00",qt100), '')
write(sprintf("%d nota(s) de R$ 50,00",qt50), '')
write(sprintf("%d nota(s) de R$ 20,00",qt20), '')
write(sprintf("%d nota(s) de R$ 10,00",qt10), '')
write(sprintf("%d nota(s) de R$ 5,00",qt5), '')
write(sprintf("%d nota(s) de R$ 2,00",qt2), '')
write(sprintf("%d nota(s) de R$ 1,00",qt1), '')