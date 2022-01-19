input = file('stdin','r')

n = as.integer(readLines(input,n=1))
n = n - 1
Fibonacci <- numeric(n)
Fibonacci[1] <- Fibonacci[2] <- 1
for (i in 3:n) Fibonacci[i] <- Fibonacci[i - 2] + Fibonacci[i - 1]
write(cat("0",Fibonacci),'')