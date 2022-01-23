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
    col = as.integer(12)
    for(i in 2:11){
        for(j in col:12){
            soma = soma + matriz[i,j];
        }
        if(i<6){
            col = col - 1
        }else if(i>6){
           col = col + 1
        }
    }
    write(sprintf("%.1f",soma),'')

}else if(op == 'M'){
    c2 = as.integer(0)
    col = as.integer(12)
    for(i in 2:11){
        for(j in col:12){
            soma = soma + matriz[i,j];
            c2 =c2 + 1
        }
        if(i <6){
            col = col - 1
        }else if(i>6){
           col = col + 1
        }
    }
    media = as.double()
    media = soma/c2
    write(sprintf("%.1f",media),'')
}