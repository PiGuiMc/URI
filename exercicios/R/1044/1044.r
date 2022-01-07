input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")
x = as.integer(line[[1]][1])
y = as.integer(line[[1]][2])

if(x < y){
        if(y %% x == 0){write(sprintf("Sao Multiplos"),'')}
        else{write(sprintf("Nao sao Multiplos"),'')}
    }else{
        if(x %% y == 0){write(sprintf("Sao Multiplos"),'')}
        else{write(sprintf("Nao sao Multiplos"),'')}
    }