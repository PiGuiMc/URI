input = file('stdin','r')

line = strsplit(readLines(input,n=1)," ")

a = as.double(line[[1]][1])
b = as.double(line[[1]][2])
c = as.double(line[[1]][3])

if ((b-c) < a && a < (b+c) && (a-c) < b && b < (a+c)&&(a-b) < c && c < (a+b)){
    per = as.double(a+b+c)
    write(sprintf("Perimetro = %.1f",per),'')

}else{
    area = as.double((((a + b) * c) / 2))
    write(sprintf("Area = %.1f",area),'')
}