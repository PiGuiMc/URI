input = file('stdin','r')
maior = as.integer(0)
menor = as.integer(0)
s = as.integer(0)
n = as.integer(readLines(input,n=1))

i = 0

while(i <n){
    s = 0
    line = strsplit(readLines(input,n=1), " ")

    x = as.integer(line[[1]][1])
    y = as.integer(line[[1]][2])

    if(x > y){
        maior = x
        menor = y
    }else{
        maior = y
        menor = x
    }
    k = as.integer(0)
    k = menor+1
    while( k < maior){
        if(k%%2!=0){
            s = s + k
        }
        k = k +1
    }
    if(x == y){
        s = 0
    }
    
    write(s,'')
    i = i +1
}