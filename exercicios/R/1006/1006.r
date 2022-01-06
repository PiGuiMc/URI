input = file('stdin','r')

a = as.double(readLines(input, n=1)) * 2
b = as.double(readLines(input, n=1)) * 3
c = as.double(readLines(input, n=1)) * 5

med = (a + b + c) / 10

write(sprintf("MEDIA = %.1f",med), '')
