input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for (i in 1:n) {
   v = as.integer(readLines(input,n=1))

   if(v == 0){
       write("NULL",'')
   }
   if(v%%2 == 0 & v > 0){
       write("EVEN POSITIVE",'')
   }else if(v%%2 !=0 & v > 0){
       write("ODD POSITIVE",'')
   }
   if(v%%2 == 0 & v < 0){
       write("EVEN NEGATIVE",'')
   }else if (v%%2 !=0 & v < 0){
       write("ODD NEGATIVE",'')
   }
}