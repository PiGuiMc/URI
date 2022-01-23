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
    inf = as.integer(6)
    sup = as.integer(7)
    for(i in 8:12){
        for(j in inf:sup){
            soma = soma + matriz[i,j];
        }
        inf = inf - 1;
        sup = sup + 1;  
    }
    write(sprintf("%.1f",soma),'')

}else if(op == 'M'){
    inf = as.integer(6)
    sup = as.integer(7)
    c2 = as.integer(0)
    for(i in 8:12){
        for(j in inf:sup){
            soma = soma + matriz[i,j];
            c2 = c2 + 1
        }
        inf = inf - 1;
        sup = sup + 1;  
    }
    media = as.double()
    media = soma/c2
    write(sprintf("%.1f",media),'')
}