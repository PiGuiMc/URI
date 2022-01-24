input = file('stdin','r')

x = as.integer(readLines(input,n=1))

for(i in 1:x){
    line = strsplit(readLines(input,n=1)," ")

    a = as.integer(line[[1]][1])
    b = as.integer(line[[1]][2])

    write(a+b,'')
}