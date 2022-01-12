input = file('stdin','r')
new = TRUE
while(new == TRUE){
    cont = as.integer(0)
    nota = as.double(0)
    op = as.integer(0)
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
    if(cont == 2){
        cont = 0
        nota = 0
        n = 0
    }
    while(TRUE){
        write("novo calculo (1-sim 2-nao)",'')
        op = as.integer(readLines(input,n=1))
        cont = 0
        if(op==2){
            new = FALSE
            break
        }else if(op == 1){
            new = TRUE
            cont = 0
            nota =0
            n = 0
            break
        }
    }
}