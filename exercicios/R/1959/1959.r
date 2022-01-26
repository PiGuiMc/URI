input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

a = as.double(line[[1]][1])
b = as.double(line[[1]][2])

write(sprintf("%d",a*b),'')