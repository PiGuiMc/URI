input = file('stdin','r')

teste = ""
teste2 = ""
n = readLines(input,n=1)

teste = n

for(i in nchar(teste):1){
    teste2 = paste(teste2,substr(teste,i,i),sep="")
}

write(teste2,'')