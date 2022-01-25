input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    v = as.integer(readLines(input,n=1))

    write(sprintf("%d",v%%2),'')
}