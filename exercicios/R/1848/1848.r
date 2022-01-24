input = file('stdin','r')

c = as.integer(0)
s = as.integer(0)

while(s != 3){
    for(i in 1:1000){
        n = readLines(input,n=1)

        if(n == "caw caw"){
            s = s + 1
            write(c,'')
            c = 0
        }
         if(n == "---"){
                c = c + 0
            }else if(n == "--*"){
                c = c + 1;
            }else if(n == "-*-"){
                c = c +2;
            }else if(n == "-**"){
                c = c + 3
            }else if(n == "*--"){
                c = c +4
            }else if(n == "*-*"){
                c = c +5
            }else if(n == "**-"){
                c = c +6
            }else if(n == "***"){
                c = c +7
            }
            if(s == 3){
                break
            }
    }
}