
input = file('stdin','r')

line = strsplit(readLines(input,n=1)," ")

precoA = as.double(line[[1]][1])
precoN = as.double(line[[1]][2])

total = as.double(((precoN*100)/precoA) - 100)

teste = paste(sprintf("%.2f",total),sep="","%")

write(teste,'')