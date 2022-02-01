input = file('stdin','r')

count = as.integer(0)

v = as.integer(readLines(input,n=1))

valor = strsplit(readLines(input,n=1), " ")

for(i in 1:5){
    if(valor[[1]][i] == v){
        count = count + 1
    }
}

write(count,'')