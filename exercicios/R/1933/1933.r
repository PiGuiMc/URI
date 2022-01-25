input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])

if(a == b){
    write(a,'')
}else if(a>b){
    write(a,'')
}else if (b > a) {
   write(b,'')
}
