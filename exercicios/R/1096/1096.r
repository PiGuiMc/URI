input = file('stdin','r')

i = as.integer(1)
j = as.integer(7)

while(i<=9){
    while(j>=5){
        write(sprintf("I=%d J=%d",i,j),'')
        j = j-1
    }
    j = 7
i = i + 2
}