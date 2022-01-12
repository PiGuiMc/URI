input = file('stdin','r')

maior = as.integer(0)
menor = as.integer(0)

x = as.integer(readLines(input,n=1))
y = as.integer(readLines(input,n=1))
i = as.integer(0)
if(x > y){
    maior = x
    menor = y
}else{
    maior = y
    menor = x
}
i = menor + 1

while(i<maior){
    if(i%%5 == 2 || i%%5==3){
        write(i,'')
    }
    i= i + 1
}