input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")
a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])

if(a == b){
        write(sprintf("O JOGO DUROU 24 HORA(S)"),'')
    }else if(a < b){
        tempo = as.integer(b - a)
        write(sprintf("O JOGO DUROU %d HORA(S)",tempo),'')
    }else if(a > b){
        tempo = as.integer(24 - (a - b))
        write(sprintf("O JOGO DUROU %d HORA(S)",tempo),'')
}