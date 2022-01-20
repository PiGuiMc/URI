input = file('stdin','r')

num = as.integer(readLines(input,n=1))

j = as.integer(0)
i = as.integer(0)

while(i<1000){
    write(sprintf("N[%d] = %d",i,j),'')

    i = i + 1
    j = j + 1

    if(num == j){
        j = 0
    }
}