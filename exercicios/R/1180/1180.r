input = file('stdin','r')

aux = as.integer(1000)
pos = as.integer(0)
i = as.integer(1)
n = as.integer(readLines(input,n=1))

line = strsplit(readLines(input,n=1)," ")

for(i in 1:n){
    teste = as.integer(line[[1]][i])
    if(teste < aux){
        aux = as.integer(line[[1]][i])
        pos = i
    }
}

write(sprintf("Menor valor: %d",aux),'')
write(sprintf("Posicao: %d",pos-1),'')