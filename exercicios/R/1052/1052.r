input = file('stdin','r')

Meses <- c("January","February","March","April","May","June","July","August","September","October","November","December")

valor = as.integer(readLines(input,n=1))
if(valor >= 1 && valor <= 12){
    write(sprintf(Meses[valor]),'')
}