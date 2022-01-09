input = file('stdin','r')

     i = as.double(0);
     j = as.double(1);
    while(i <= 2){
        if( i == 0 || i == 1 || i > 1.8){
            write(sprintf("I=%0.f J=%0.f",i,j+i),'');
            write(sprintf("I=%0.f J=%0.f",i,j+1+i),'');
            write(sprintf("I=%0.f J=%0.f",i,j+2+i),'');
            }else{
            write(sprintf("I=%.1f J=%.1f",i,j+i),'');
            write(sprintf("I=%.1f J=%.1f",i,j+1+i),'');
            write(sprintf("I=%.1f J=%.1f",i,j+2+i),'');
            }
            i = i + 0.2;
    }