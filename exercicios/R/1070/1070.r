input = file('stdin','r')

x = as.integer(readLines(input,n=1))
t = as.integer(x + 12)
i = as.integer(x)

while(i < t){
   if((i%%2)!=0){
      write(i,'')
   }
   i = i + 1
}