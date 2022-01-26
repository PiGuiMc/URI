input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

a = as.numeric(line[[1]][1])
b = as.numeric(line[[1]][2])

total = a*b
write(sprintf("%.0f",total),'')