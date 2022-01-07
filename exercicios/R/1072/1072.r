input = file('stdin','r')

x = as.integer(readLines(input,n=1))

qt_in = as.integer(0)
qt_out = as.integer(0)

for (i in 1:x) {
   v = as.integer(readLines(input,n=1))

   if (v >= 0 && v <=20) {
      qt_in = qt_in + 1
   }else {
      qt_out = qt_out + 1
   }
}
write(sprintf("%d in",qt_in),'')
write(sprintf("%d out",qt_out),'')