input = file('stdin','r')

qt <- c(1:6)

media = as.double(0.0)
cont = as.integer(0)
soma = as.double(0.0)

for (i in qt) {
   v = as.double(readLines(input,n=1))

   if (v > 0) {
      soma = soma + v
      cont = cont + 1
   }
}
media = soma / cont
write(sprintf("%d valores positivos",cont),'')
write(sprintf("%.1f",media),'')