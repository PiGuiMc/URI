input = file('stdin','r')

while(TRUE){
    teste <- c()
    soma = as.integer(0)
    line = strsplit(readLines(input,n=1), " ")

    m = as.integer(line[[1]][1])
    n = as.integer(line[[1]][2])

    if(m > n){
        maior = as.integer(m)
        menor = as.integer(n)
    }else{
        maior = as.integer(n)
        menor = as.integer(m)
    }
    i = as.integer(menor)
    if(m == 0 || n== 0){
        break
    }
      
    while(i <= maior){
        soma = soma + i
        teste[i] <- i
        i = i + 1
    }
    if(soma > 0){
    teste <- na.omit(teste)
    write(cat(teste,sprintf("Sum=%d",soma)),'')}
}