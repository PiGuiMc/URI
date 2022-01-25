input = file('stdin','r')

line = strsplit(readLines(input,n=1)," ")

t1 = as.integer(line[[1]][1])
t2 = as.integer(line[[1]][2])
t3 = as.integer(line[[1]][3])
t4 = as.integer(line[[1]][4])

write(t1-1 + t2-1 + t3-1 + t4,'')