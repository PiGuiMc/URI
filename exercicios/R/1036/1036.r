input = file('stdin','r')

line = strsplit(readLines(input, n=1), " ")

a = as.double(line[[1]][1])
b = as.double(line[[1]][2])
c = as.double(line[[1]][3])

delta = (b*b) - 4*(a*c)

div = 2 * a

if ((div == 0) | (delta < 0)){
    write(sprintf("Impossivel calcular"),'')
}else{
    r1 = as.double((-b + sqrt(delta)) / (div))

    r2 = as.double((-b - sqrt(delta)) / (div))
    write(sprintf("R1 = %.5f",r1),'')
    write(sprintf("R2 = %.5f",r2),'')
}