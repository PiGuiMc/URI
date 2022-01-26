input = file('stdin','r')

n = as.integer(readLines(input,n=1))

cod_ap = as.integer(0)
nt_ap = as.double(0)
for(i in 1:n){
    valor = strsplit(readLines(input,n=1), " ")

    cod = as.integer(valor[[1]][1])
    nota = as.double(valor[[1]][2])
    
    if(nota >= 8){
        if(nota > nt_ap){
            nt_ap = nota
            cod_ap = cod
        }
        
    }
}

if(cod_ap > 0){
    write(cod_ap,'')
}else{
    write("Minimum note not reached",'')
}

