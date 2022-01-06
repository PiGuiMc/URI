input = file('stdin','r')

line = strsplit(readLines(input, n=1), " ")

a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])
c = as.integer(line[[1]][3])
d = as.integer(line[[1]][4])

if(b > c & d > a & (c + d) > (a + b) & c > 0 & d > 0){
        write(sprintf("Valores aceitos"),'')
}else{ write(sprintf("Valores nao aceitos"),'')}
