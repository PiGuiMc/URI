input = file('stdin','r')

cont = as.integer(0)
nota = as.double(0)
while(cont <2 ){
    n = as.double(readLines(input,n=1))

    if(n < 0.0 || n > 10.0){
        write("nota invalida",'')
    }else if(n >=0 && n <=10){
        cont = cont + 1
        nota  = nota + n
    }
}
write(sprintf("media = %.2f",nota/2),'')