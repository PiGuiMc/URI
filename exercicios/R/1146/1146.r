input =file('stdin','r')

while(TRUE){
    
    n = as.integer(readLines(input,n=1))
    teste <- c()
    if(n == 0){
        break
    }else{

        for(i in 1:n){
            cat(i," ")
        }
        write("",'')
    }
}