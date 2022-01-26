input = file('stdin','r')

vl =  as.double(0)

n = as.integer(readLines(input,n=1))


for(i in 1:n){

    line = strsplit(readLines(input,n=1) , " ")

    cod = as.integer(line[[1]][1])
    qt = as.double(line[[1]][2])

    if(cod == 1001){
        vl = vl + qt * 1.5
    }else if(cod == 1002){
        vl = vl + qt * 2.5
    }else if(cod == 1003){
        vl = vl + qt * 3.5
    }else if(cod == 1004){
        vl = vl + qt * 4.5
    }else if(cod == 1005){
        vl = vl + qt * 5.5
    }
}
write(sprintf("%.2f",vl),'')


