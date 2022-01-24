input = file('stdin','r')

while(TRUE){
    line = readLines(input,n=1)
    n = as.integer(line)

    if(length(line) == 0){
        break
    }else if(n == 0){
         write("vai ter copa!",'')
    }else if(n > 0){
        write("vai ter duas!",'')
    }
}

