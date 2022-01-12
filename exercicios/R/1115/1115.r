input = file('stdin','r')

while(TRUE){
    line = strsplit(readLines(input,n=1), " ")
    
    x = as.integer(line[[1]][1])
    y = as.integer(line[[1]][2])

    if(x ==0 || y == 0){
        break
    }
    if(x > 0 && y > 0){
        write("primeiro",'')
    }else if(x < 0 && y > 0){
        write("segundo",'')
    }else if(x < 0 && y < 0){
        write("terceiro",'')
    }else if(x > 0 && y < 0){
        write("quarto",'')
    }
}