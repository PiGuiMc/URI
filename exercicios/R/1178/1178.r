input = file('stdin','r')

a = as.integer(1)
c = as.double(0)
d = as.double(0)

n <- double(100)

b = as.double(readLines(input,n=1))
n[a] = b

for(a in 1:100){
    write(sprintf("N[%d] = %.4f",a-1,n[a]),'')
    b = b / 2
    n[a+1] = b
}
