input = file('stdin','r')

while(TRUE){
    soma = as.integer(0)
    i = as.integer(1)
    n = as.integer(readLines(input,n=1))

    if(n==0){
        break
    }
    if(n!=0){
        while(i<=5){
            if(n%%2==0){
                soma = soma + n
                
                n = n + 1
                i = i + 1
            }else{
                n = n + 1
            }
        }
        write(soma,'')
    }
}