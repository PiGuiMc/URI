input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    s = 0
    j = 1
    num = as.integer(readLines(input,n=1))

    while(j<=num){
        if(num%%j==0){
            s = s + 1
        }
        j = j + 1
    }
    if(s > 2){
        write(sprintf("%d nao eh primo",num),'')
    }else {
       write(sprintf("%d eh primo",num),'')
    }
}