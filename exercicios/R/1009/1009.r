input = file('stdin','r')

nome = readLines(input, n=1)
salario = as.double(readLines(input, n=1))
vendas = as.double(readLines(input, n=1))

total = (vendas * 0.15) + salario

write(sprintf("TOTAL = R$ %.2f",total),'')