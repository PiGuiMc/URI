input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    s = as.integer(0)
    j = as.integer(1)

    num = as.integer(readLines(input,n=1))

    while(j<num){
        if(num %% j ==0){
            s = s + j
        }
        j = j + 1
    }
    if(s == num){
        write(sprintf("%d eh perfeito",num),'')
    }else{
        write(sprintf("%d nao eh perfeito",num),'')
    }
}