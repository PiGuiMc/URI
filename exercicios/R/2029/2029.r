input = file('stdin','r')

while(TRUE){ 
    volume = as.double(readLines(input,n=1))
    diametro = as.double(readLines(input,n=1))

    v_pi = as.double(3.14156)

    raio = diametro/2

    area = v_pi * (raio*raio)

    altura = volume/area

    write(sprintf("ALTURA = %.2f",altura),'')
    write(sprintf("AREA = %.2f",area),'')
    if(length(volume) == 0){
        break;}
}