input = file('stdin','r')

soma = as.double(0)
matriz <- matrix( data = 1:144, nrow = 12, ncol = 12, byrow = TRUE)

op = readLines(input,n=1)

for(i in 1:12){
    for(j in 1:12){
    valor = as.double(readLines(input,n=1))
    matriz[i,j] = valor
    }
}

if(op == 'S'){
    c = as.integer(2)
    for(i in 1:11){
        for(j in c:12){
            soma = soma + matriz[i,j];
        }
        c = c + 1;
    }
    write(sprintf("%.1f",soma),'')
}else if(op == 'M'){
    c = as.integer(2)
    c2 = as.integer(0)
    for(i in 1:11){
        for(j in c:12){
            soma = soma + matriz[i,j]
            c2 = c2 + 1
        }
        c = c + 1
    }
    media = as.double()
    media = soma/c2
    write(sprintf("%.1f",media),'')
}