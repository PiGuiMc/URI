input = file('stdin','r')

soma = as.integer(0)

media = as.double(0)

i = as.double(0)

n = as.integer(readLines(input,n=1))

while(n >=0){
    soma = soma + n
    i = i + 1

    n = as.integer(readLines(input,n=1))
}

media = soma /i;
write(sprintf("%.2f",media),'')