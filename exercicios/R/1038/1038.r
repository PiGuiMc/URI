input = file('stdin','r')

preco <- c(4.00, 4.50, 5.00, 2.00, 1.50)

line = strsplit(readLines(input,n=1), " ")
cod = as.integer(line[[1]][1])
qt = as.integer(line[[1]][2])

n_preco = as.double(preco[cod])

total = as.double( n_preco * qt)

write(sprintf("Total: R$ %.2f",total),'')
