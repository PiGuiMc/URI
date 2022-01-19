input = file('stdin','r')

vector <- c(100)

for(i in 1:100){
    num = as.double(readLines(input,n=1))

    vector[i] = num
}
i = as.integer(1)
while(i<=100){
    if(vector[i] <=10){
    write(sprintf("A[%d] = %.1f",i-1,vector[i]),'')
    }
    i=i+1
}