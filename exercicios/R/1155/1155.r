input = file('stdin','r')

s = as.double(0)

for(i in 1:101){
    s = (as.double(s) + as.double(1)/as.double(i))- as.double(0.0001)
}
write(sprintf("%.2f",s),'')