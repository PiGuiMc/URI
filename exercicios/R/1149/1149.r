input = file('stdin','r')

line = strsplit(readLines(input,n=1)," ")

a = as.integer(line[[1]][1])
n = as.integer(line[[1]][2])

contv = as.integer(1)

while(n<=0){
    contv = contv+1
    n = as.integer(line[[1]][contv])
}

soma = as.integer(0)

for(i in 1:n-1){
    soma = soma + (a + i)
}
write(soma,'')