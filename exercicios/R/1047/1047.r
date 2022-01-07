input = file('stdin','r')

line = strsplit(readLines(input, n=1), " ")

hi = as.integer(line[[1]][1])
mi = as.integer(line[[1]][2])
hf = as.integer(line[[1]][3])
mf = as.integer(line[[1]][4])

m = as.integer()
h = as.integer()

if(hi < hf){
    h = hf - hi;
    if(mi < mf){
        m = mf - mi;
    }else if(mi > mf){
        h = h - 1;
        m = (60 - mi) + mf;
    }else if(mi == mf){
        m = 0;
    }
}
if(hi > hf){
    h = (24 - hi) + hf;
    if(mi < mf){
        m = mf - mi;
    }else if(mi > mf){
        h = h - 1;
        m = (60 - mi) + mf;
    }else if(mi == mf){
        m = 0;
    }
}
if(hi == hf){
    if(mi < mf){
        m = mf - mi;
        h = 0;
    }else if(mi > mf){
        m = (60 - mi ) + mf;
        h = 23;
    }else if(mi == mf){
        h = 24;
        m = 0;
    }
}
write(sprintf("O JOGO DUROU %d HORA(S) E %d MINUTO(S)",h,m),'')