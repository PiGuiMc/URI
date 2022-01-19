input = file('stdin','r')

i = as.integer(2)
s = as.integer(1)

x = as.integer(readLines(input,n=1))

z = as.integer(x - 1)

soma = as.integer(x)

while(z <= x){
    z = as.integer(readLines(input,n=1))
}
while(soma <= z){
    soma = soma + x + s

    if(soma <= z){
        i = i +1
        s = s + 1
    }
}

write(i,'')