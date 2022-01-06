input = file('stdin','r')

dist = as.integer(readLines(input, n=1))
comb = as.double(readLines(input, n=1))

litros = dist / comb

write(sprintf("%.3f km/l",litros), '')