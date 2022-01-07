input = file('stdin','r')

n1 = as.integer(readLines(input,n=1))
n2 = as.integer(readLines(input,n=1))

maior = as.integer(0)
menor = as.integer(0)
soma = as.integer(0)

if(n1 > n2){
    maior = n1;
    menor = n2;
}else
{
    maior = n2;
    menor = n1;
}

    menor = menor + 1;

while(menor < maior){
    if(menor %% 2 != 0){
        soma =soma + menor;
    }
        menor =menor + 1;
}
write(soma,'')