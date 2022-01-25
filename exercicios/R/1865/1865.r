input = file('stdin','r')

n = as.integer(readLines(input,n=1))

for(i in 1:n){
    v = strsplit(readLines(input,n=1), " ")

    if(v[[1]][1] == "Thor"){write("Y",'')}else{write("N",'')}
}


