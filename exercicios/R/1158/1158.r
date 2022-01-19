input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    soma = as.integer(0)
    j = as.integer(1)
    line = strsplit(readLines(input,n=1), " ")

    x = as.integer(line[[1]][1])
    y = as.integer(line[[1]][2])

    while(j<=y){
        if(x%%2!=0){
            soma = soma + x

            x = x +1
            j = j + 1
        }else if(x%%2 == 0){
            x = x + 1
        }
        
    }
    write(soma,'')
}