input = file('stdin','r')

flag = as.integer(0)
sum = as.integer(0)

line = strsplit(readLines(input,n=1), " ")

x = as.integer(line[[1]][1])
y = as.integer(line[[1]][2])

a <-c(y)

line2 = strsplit(readLines(input,n=1), " ")

for(i in 1:y){
    a[i] = as.integer(line2[[1]][i])
}

for(j in 2:y){
    if(a[j] > a[j-1]){
        sum = (a[j] - a[j-1])
    }else{
        sum = (a[j-1] - a[j]);
    }

    if(sum <= x){
        flag = 1
    }else{
        flag = 0
        break
    }
}
if(flag == 1){
    write("YOU WIN",'');
}else{
    write("GAME OVER",'');}