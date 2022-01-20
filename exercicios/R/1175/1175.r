input = file('stdin','r')

vector <- c(20)

for(i in 20:1){
    num = as.integer(readLines(input,n=1))

    vector[i] = num
}

for(j in 1:20){
    write(sprintf("N[%d] = %d",j-1,vector[j]),'')
}