input = file('stdin','r')

i = as.integer(-2)
j = as.integer(60)

while(j >=0){
    write(sprintf("I=%d J=%d",i+3,j),'')
    i = i + 3
    j = j - 5
}