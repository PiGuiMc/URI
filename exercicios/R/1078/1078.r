input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:10){
    write(sprintf("%d x %d = %d",i,n,i*n),'')
}