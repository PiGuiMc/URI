input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

n1 = as.double(line[[1]][1])
n2 = as.double(line[[1]][2])
n3 = as.double(line[[1]][3])
n4 = as.double(line[[1]][4])

media = as.double(((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1))/10)

if (media >=7) {
   write(sprintf("Media: %.1f",media),'')
   write(sprintf("Aluno aprovado."),'')
} else if (media >= 5 & media < 7) {
   write(sprintf("Media: %.1f",media),'')
   write(sprintf("Aluno em exame."),'')
   n_exa = as.double(readLines(input,n=1))
   n_media = as.double((media + n_exa))/2
   if (n_media>=5) {
    write(sprintf("Nota do exame: %.1f",n_exa),'')
    write(sprintf("Aluno aprovado."),'')
    write(sprintf("Media final: %.1f",n_media),'')
   } else if (n_media < 5) {
    write(sprintf("Nota do exame: %.1f",n_exa),'')
    write(sprintf("Aluno reprovado."),'')
    write(sprintf("Media final: %.1f",n_media),'')
   }
} else if (media < 5) {
   write(sprintf("Media: %.1f",media),'')
   write(sprintf("Aluno reprovado."),'')
}
