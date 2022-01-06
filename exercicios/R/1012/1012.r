input = file('stdin','r')

line = strsplit(readLines(input, n=1), " ")
a = as.double(line[[1]][1])
b = as.double(line[[1]][2])
c = as.double(line[[1]][3])

tri = (a * c) / 2;

cir = 3.14159 * (c * c);

trap = ((a + b) / 2)* c;

qua = b * b;
    
ret = a * b;

write(sprintf("TRIANGULO: %.3f",tri),'')
write(sprintf("CIRCULO: %.3f",cir),'')
write(sprintf("TRAPEZIO: %.3f",trap),'')
write(sprintf("QUADRADO: %.3f",qua),'')
write(sprintf("RETANGULO: %.3f",ret),'')