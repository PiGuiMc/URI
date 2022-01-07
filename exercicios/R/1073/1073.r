input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for (i in 1:n) {
   if (i%%2==0) {
      write(sprintf("%d^2 = %d",i,i**2),'')
   }
}