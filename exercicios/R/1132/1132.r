input = file('stdin','r')

x = as.integer(readLines(input,n=1))
y = as.integer(readLines(input,n=1))

maior = as.integer(0)
menor = as.integer(0)
cont = as.integer(0)
if(x > y){
    maior = as.integer(x)
    menor = as.integer(y)
}else{
    maior = as.integer(y)
    menor = as.integer(x)
}

for(i in menor:maior){
    if(i %%13 != 0){
        cont = cont + i
    }
}
write(cont,'')