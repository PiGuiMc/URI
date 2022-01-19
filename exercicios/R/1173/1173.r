input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 0:9){
    write(sprintf("N[%d] = %d",i,n),'')
    n = n * 2
}