input = file('stdin','r')

while(TRUE){
    line = strsplit(readLines(input,n=1), " ")
    x = as.integer(line[[1]][1])
    y = as.integer(line[[1]][2])

    if(x==y){
        break
    }
    if(x > y){
        write("Decrescente",'')
    }else{
        write("Crescente",'')
    }

}