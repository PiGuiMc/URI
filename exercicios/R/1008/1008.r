input = file('stdin','r')

cod = as.integer(readLines(input, n=1))
horas = as.integer(readLines(input, n=1))
valor = as.double(readLines(input, n=1))

salario = valor * horas

write(sprintf("NUMBER = %d",cod),'')
write(sprintf("SALARY = U$ %.2f",salario),'')