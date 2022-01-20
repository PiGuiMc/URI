input = file('stdin','r')

impar <- c(15)
par <- c(15)

for(i in 1:15){
    num = as.integer(readLines(input,n=1))

    if(num%%2==0){
        par[a] = num
    }else if(num%%2!=0){
        impar[a] = num
    }
    if(length(par)==5){
        ix = 0
        for(v in par){
            write(sprintf("par[%d] = %d", ix,v),'')
            ix = ix + 1
        }
    }
    if(length(impar)==5){
        ix = 0
        for(v in impar){
            write(sprintf("impar[%d] = %d", ix,v),'')
            ix = ix + 1
        }
    }
}
if(length(impar)> 0){
    ix = 0
    for(v in impar){
        write(sprintf("impar[%d] = %d", ix,v),'')
        ix = ix + 1
    }
}
if(length(par)>0){
    ix = 0
    for( v in par){
        write(sprintf("par[%d] = %d",ix,v),'')
        ix = ix + 1
    }
}