input = file('stdin','r')

soma = as.double(0)
neg = as.double(0)
matriz = matrix(c(144),nrow= 12, ncol = 12, byrow = TRUE)
linha = as.integer(readLines(input,n=1))

op = readLines(input,n=1)



for(i in 1:144){
    valor = as.double(readLines(input,n=1))
    matriz[i] = valor
}

for(j in 1:12){
        soma = soma + matriz[j,linha]
}

if(op == 'S'){
    write(sprintf("neg %.1f",neg),'')
    write(sprintf("soma %.1f",soma),'')
}else{
    media = as.double(soma/12)
    write(sprintf("%.1f",media),'')
}
print(matriz)
for(j in 1:12){
        write(matriz[j,linha],'')
}