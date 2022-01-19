input = file('stdin','r')

for(i in 0:9){
    num = as.integer(readLines(input,n=1))

    if(num <=0){
        write(sprintf("X[%d] = 1",i),'')
    }else{
        write(sprintf("X[%d] = %d",i,num),'')
    }
}

