input = file('stdin','r')

n = as.integer(readLines(input,n=1))
c = as.integer(0)
r = as.integer(0)
s = as.integer(0)

for(i in 1:n){
    line = strsplit(readLines(input,n=1)," ")

    qt = as.integer(line[[1]][1])
    op = (line[[1]][2])
 
    if(op == "C"){
        c = c + qt
    }else if(op == "R") {
       r = r + qt
    }else if(op == "S"){
        s = s + qt
    }
    
}   
    str1 = 'Percentual de coelhos: %.2f '
    por = %
    write(sprintf("Total: %d cobaias",(c+r+s)),'')
    write(sprintf("Total de coelhos: %d",c),'')
    write(sprintf("Total de ratos: %d",r),'')
    write(sprintf("Total de sapos: %d",s),'')
    write(sprintf(paste(str1,por),((c*100)/(c+r+s)),paste("%")),'')
    write(sprintf("Percentual de ratos: %.2f",((r*100)/(c+r+s))),'')
    write(sprintf("Percentual de saapos: %.2f",((s*100)/(c+r+s))),'')
    