input = file('stdin','r')

x = as.integer(1)

n = as.integer(readLines(input, n=1))

for(i in 1:n){
    write(sprintf("%d %d %d PUM",x,x+1,x+2),'')
    x = x + 4
}