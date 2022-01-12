input = file('stdin','r')

while(TRUE){
    v = as.integer(readLines(input,n=1))

    if(v == 2002){
        write("Acesso Permitido",'')
        break
    }else{
        write("Senha Invalida",'')
    }
}