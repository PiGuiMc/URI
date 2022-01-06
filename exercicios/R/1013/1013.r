input = file('stdin','r')

line = strsplit(readLines(input, n=1)," ")
a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])
c = as.integer(line[[1]][3])

maiorAb = ((a + b + abs(a - b))/2)
maiorABC = ((maiorAb + c + abs(maiorAb - c))/2)

write(sprintf("%d eh o maior",maiorABC), '')