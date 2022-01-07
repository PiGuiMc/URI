input = file('stdin','r')

x = as.integer(readLines(input,n=1))
count = as.integer(0)
for (i in 1:x) {
   if (i%%2!=0) {
      write(i,'')
   }
}
