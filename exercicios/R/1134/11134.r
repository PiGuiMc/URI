input = file('stdin','r')
a = as.integer(0)
g = as.integer(0)
d = as.integer(0)
while(TRUE){
    op = as.integer(readLines(input,n=1))

    if(op == 1){
        a = a + 1
    }else if(op ==2){
        g = g  + 1
    }else if(op==3){
        d = d + 1
    }else if(op ==4){
        write("MUITO OBRIGADO",'')
        write(sprintf("Alcool: %d",a),'')
        write(sprintf("Gasolina: %d",g),'')
        write(sprintf("Diesel: %d",d),'')
        break
    }
}