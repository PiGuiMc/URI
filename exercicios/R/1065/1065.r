input = file('stdin','r')

qt <-c(1:5)

count = as.integer(0)

for (i in qt) {
   v = as.integer(readLines(input,n=1))

   if (v%%2==0) {
      count = count + 1
   }
}
write(sprintf("%d valores pares",count),'')