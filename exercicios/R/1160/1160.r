input = file('stdin','r')

n = as.integer(readLines(input,n=1))

j = as.integer(0)
while(j<n){
    anos = as.integer(0)
    line = strsplit(readLines(input,n=1), " ")

    pa = as.integer(line[[1]][1])
    pb = as.integer(line[[1]][2])
    g1 = as.double(line[[1]][3])
    g2 = as.double(line[[1]][4])

    g1 = g1/100
    g2 = g2/100
    while(TRUE){

        pa = pa + (as.integer(pa * g1))
        pb = pb + (as.integer(pb * g2))

        anos = anos + 1

        if(pa > pb || anos > 100){
            break
        }
    }

    if(anos <= 100){
        write(sprintf("%d anos.",anos),'')
    }else{
        write(sprintf("Mais de 1 seculo."),'')
    }

    j = j +1
}