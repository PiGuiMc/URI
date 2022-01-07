input = file ('stdin','r')

valor <- rep(NA,3)

line = strsplit(readLines(input,n=1), " ")

a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])
c = as.integer(line[[1]][3])

if( a > b && a > c){
    d = as.integer(a)
    if( b > c){
        e = as.integer(b)
        f = as.integer(c)
    }else{
        e = as.integer(c)
        f = as.integer(b)}
        }
if( b > a && b > c){
    d = as.integer(b)
    if( a > c){
        e = as.integer(a)
        f = as.integer(c)
    }else{
        e = as.integer(c)
        f = as.integer(a)}
    }
if( c > a && c > b){
    d = as.integer(c)
    if(a > b){
        e = as.integer(a)
        f = as.integer(b)
    }else{
        f = as.integer(a)
        e = as.integer(b)}
}
write(f,'')
write(e,'')
write(d,'')
write('','')
write(a,'')
write(b,'')
write(c,'')