input = file('stdin','r')

qt <-c(1:5)

c_pares = as.integer(0)
c_impares = as.integer(0)
c_pos = as.integer(0)
c_neg = as.integer(0)
for (i in qt) {
   v = as.integer(readLines(input,n=1))

   if (v%%2==0) {
      c_pares = c_pares + 1
   }else if (v%%2!=0) {
      c_impares = c_impares + 1
   }
    if (v > 0) {
      c_pos = c_pos + 1
   }else if (v < 0) {
      c_neg = c_neg + 1
   }
}
write(sprintf("%d valor(es) par(es)",c_pares),'')
write(sprintf("%d valor(es) impar(es)",c_impares),'')
write(sprintf("%d valor(es) positivo(s)",c_pos),'')
write(sprintf("%d valor(es) negativo(s)",c_neg),'')