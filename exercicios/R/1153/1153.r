input = file('stdin','r')

n = as.integer(readLines(input,n=1))

fatorial = as.integer(1)

while(n>=1){
    fatorial = fatorial * n
    n = n -1
    }
write(fatorial,'')