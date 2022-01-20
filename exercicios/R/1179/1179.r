input = file('stdin','r')

qt <- (1:15)

p = as.integer(1)
im = as.integer(1)
j = as.integer(1)
par <- c(5)
impar <- c(5)

for(i in qt){
    num = as.integer(readLines(input,n=1))

    if(num%%2==0){
        par[p] = num
        p = p + 1
    }
    else if(num%%2!=0){
        impar[im] = num
        im = im + 1
    }

     if(length(par)==5){
        while(j<=5){
            write(sprintf("par[%d] = %d",j-1,par[j]),'')
            j = j + 1
        }
        j = 0
        p = 1
        par <- c(0)
    }
    else if(length(impar)==5){
        while(j<=5){
            write(sprintf("impar[%d] = %d",j-1,impar[j]),'')
            j = j + 1
        }
        j = 1
        im = 1
        impar <- c(0)
    }
}

if(length(impar)>0){
    while(j<=length(impar)){
        write(sprintf("impar[%d] = %d",j-1,na.omit(impar[j])),'')
        j = j + 1
    }
    j = 1
}
if(length(par)>0){
    while(j<=length(par)){
        write(sprintf("par[%d] = %d",j-1,na.omit(par[j])),'')
        j = j + 1
    }
    j = 0
}
