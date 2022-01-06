input = file('stdin','r')

a = as.integer(readLines(input, n=1))
b = as.integer(readLines(input, n=1))

prod = a * b

write(sprintf("PROD = %d",prod),'')