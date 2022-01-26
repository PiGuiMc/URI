input = file('stdin','r')

pos = as.integer(0)
soma = as.integer(0)

total = as.numeric(0)
ataques = as.numeric(0)

continua = TRUE;

n = as.integer(readLines(input,n=1))

nums <- c(n)

valor = strsplit(readLines(input,n=1)," ")

for(j in 1:n){
    nums[j] = as.integer(valor[[1]][j])
    total = total + nums[j]

    if(nums[j]%%2==0 && continua){
        ataques = j+1
        soma = soma + ((j*2)+1) - pos
        continua = FALSE
        break
    }
    if(nums[j]-1 == 0 && continua){
        pos = j + 1
    }
}

if(soma > 0){
    total = total - soma
}else{
    ataques = n
    total = total - ataques
}
write(sprintf("%.0f %0.f",ataques,total),'')
