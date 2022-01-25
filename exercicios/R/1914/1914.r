input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    line = strsplit(readLines(input,n=1), " ")

    p1 = line[[1]][1]
    op1 = line[[1]][2]

    p2 = line[[1]][3]
    op2 = line[[1]][4]

    valor = strsplit(readLines(input,n=1), " ")
    v1 = as.integer(valor[[1]][1])
    v2 = as.integer(valor[[1]][2])

    if((v1+v2)%%2==0){
        if(op1 == "PAR"){write(p1,'')}else{write(p2,'')}
    }
    if((v1+v2)%%2!=0){
        if(op1 == "IMPAR"){write(p1,'')}else{write(p2,'')}
    }
}