input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    line = strsplit(readLines(input,n=1)," ")

    x = as.integer(line[[1]][1])
    y = as.integer(line[[1]][2])

    if(y == 0 ){
        write("divisao impossivel",'')
    }else{
        div = as.double(x/y)
        write(sprintf("%.1f",div),'')
    }
}