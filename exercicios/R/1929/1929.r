input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])
c = as.integer(line[[1]][3])
d = as.integer(line[[1]][4])

if(a > 0 && a<= 100 && b > 0 && b <= 100 && c > 0 && c <= 100 && d > 0 && d<=100){
                
    if(((a+b)>c) && ((b+c) > a) && ((a+c)>b)){
        write("S",'')
    }else if(((b + c) > d) && ((c + d) > b) && ((b + d) > c)){
        write("S",'')
    }else if(((a + c) > d) && ((c + d) >a) && ((a + d > c))){
        write("S",'')
    }else if(((a + b)> d) && ((b + d) > a) && ((a + d > b))){
        write("S",'')
    }else{
        write("N",'')
            }
}