input = file('stdin','r')

t = as.integer(readLines(input,n=1))

for(i in 1:t){
    n = as.integer(readLines(input,n=1))

    f <- numeric(n)

    f[1] = 0
    f[2] = 1

    if(n>1){
        for(j in 2:n+1){
            f[j] = f[j-2]+f[j-1]
        }
        write(sprintf("Fib(%d) = %.0f",j-1,f[j]),'')
    }else if(n<=1){
        write(sprintf("Fib(%d) = %d",n,n),'')
    }
}