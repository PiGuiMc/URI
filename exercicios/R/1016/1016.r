input = file('stdin','r')

n = as.integer(readLines(input, n=1))

tempo = n * 2

write(sprintf("%d minutos",tempo), '')