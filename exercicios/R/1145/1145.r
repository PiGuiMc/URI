input = file('stdin','r')

count = as.integer(1)

line = strsplit(readLines(input,n=1), " ")

x = as.integer(line[[1]][1])
y = as.integer(line[[1]][2])

teste <-c()
for(i in 1:y){
    teste[i] = i
}