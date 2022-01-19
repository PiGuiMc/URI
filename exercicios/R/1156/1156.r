input = file('stdin','r')

s = as.double(0)
j = as.double(1)
i = 1
while(i<40){
    s = as.double(s + as.double(i) / j)
    j = j * 2
    i = i + 2
}
write(sprintf("%.2f",s),'')