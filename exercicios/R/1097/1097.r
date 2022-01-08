input = file('stdin','r')

a = 7
b = 6
c = 5
i = 1

while(i<=9){
    write(sprintf("I=%d J=%d",i,a),'');
    write(sprintf("I=%d J=%d",i,b),'');
    write(sprintf("I=%d J=%d",i,c),'')

    a = a+2
    b = b + 2
    c = c+2
    i = i+2
}