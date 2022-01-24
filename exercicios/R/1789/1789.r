input = file('stdin','r')

while(TRUE){
    line = readLines(input,n=1)
    n = as.integer(line)

    if(length(line)==0){
        break
    }

    valor = strsplit(readLines(input,n=1)," ")
    m = as.integer(0)
    op = as.integer(0)
    for(i in 1:n){
        if(as.integer(valor[[1]][i]) > m){
            m = as.integer(valor[[1]][i])
        }
    }
    if(m < 10){
        op = 1
    }else if(m >= 10 && m<20){
        op = 2
    }else{
        op = 3
    }
    write(op,'')
}