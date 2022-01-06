input = file('stdin','r')

horas = as.integer(readLines(input, n=1))
km_h = as.integer(readLines(input, n=1))

litros = (horas * km_h) / 12

write(sprintf("%.3f",litros),'')