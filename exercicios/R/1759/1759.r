input = file('stdin','r')

x = as.integer(readLines(input,n=1))
r = paste(strrep("Ho ",x),sep=" ",end="!")

write(sprintf(r),'')