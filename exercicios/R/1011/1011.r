input = file('stdin','r')

raio = as.double(readLines(input, n=1))

volume = (4/3) * (3.14159 * (raio * raio * raio))

write(sprintf("VOLUME = %.3f",volume),'')