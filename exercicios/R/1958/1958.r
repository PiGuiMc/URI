input = file('stdin','r')

x = as.double(readLines(input,n=1))

write(sprintf("%e",x),'')