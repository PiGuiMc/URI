input = file('stdin','r')

n = as.integer(readLines(input,n=1))
i = 0
while(i < n){
    media = as.double(0)

    line = strsplit(readLines(input,n=1)," ")

    n1 = as.double(line[[1]][1])
    n2 = as.double(line[[1]][2])
    n3 = as.double(line[[1]][3])

    media = ((n1*2+n2*3+n3*5)/10)

    write(sprintf("%.1f",media),'')
    i = i + 1
}