input = file('stdin','r')

n <- c(1:6)
c = as.integer(0)

for (i in n) {
   v = as.double(readLines(input,n=1))
   if (v > 0) {
      c = as.integer(c + 1)
   }
}
write(sprintf("%d valores positivos",c),'')