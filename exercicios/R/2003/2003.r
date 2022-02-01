input = file('stdin','r')

while(TRUE){ 
    line = strsplit(readLines(input,n=1), ":")
    hmax = as.integer(line[[1]][1])
    mmax = as.integer(line[[1]][2])

    hh = as.integer((hmax+1) - 8)

    if(hh < 0){
        write("Atraso maximo: 0",'')
    }else{
        mmax = mmax + 60 * hh
        write(sprintf("Atraso maximo: %d",mmax),'')
    }

    if(length(line) == 0){
        break;}
}