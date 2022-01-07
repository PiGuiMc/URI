input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

a = as.double(line[[1]][1])
b = as.double(line[[1]][2])
c = as.double(line[[1]][3])

if(a >= (b+c) || b >= (a+c) || c >= (a+b)){
        write(sprintf("NAO FORMA TRIANGULO"),'')
    }else if(a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == (a*a + b*b)){
        write(sprintf("TRIANGULO RETANGULO"),'')
    }else if(a*a > (b*b + c*c) || b*b > (a*a + c*c) || c*c > (a*a + b*b)){
        write(sprintf("TRIANGULO OBTUSANGULO"),'')
    }else if(a*a < (b*b + c*c) || b*b < (a*a + c*c) || c*c < (a*a + b*b)){
        write(sprintf("TRIANGULO ACUTANGULO"),'')}
if(a == b && a == c){
    write(sprintf("TRIANGULO EQUILATERO"),'')
    }
if((a == b && a != c)  || (a == c && a != b) || (b == c && b != a)){
    write(sprintf("TRIANGULO ISOSCELES"),'')
    }