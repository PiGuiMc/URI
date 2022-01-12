input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    write(sprintf("%d %d %d",i,i^2,i^3),'')
    write(sprintf("%d %d %d",i,i^2+1,i^3+1),'')
}