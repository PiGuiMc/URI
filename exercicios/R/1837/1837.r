input = file('stdin','r')

line = strsplit(readLines(input,n=1), " ")

a = as.integer(line[[1]][1])
b = as.integer(line[[1]][2])

r = as.integer(0)
q = as.integer(0)
for(r in 0:(abs(b))){
    if(((a-r)%% b) == 0){
        q = as.integer((a-r)/b)
        break
    }
}
write(sprintf("%d %d",q,r),'')