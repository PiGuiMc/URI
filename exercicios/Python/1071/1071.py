n1 = int(input());
n2 = int(input());

maior = n1 if n1 > n2 else n2;
menor = n2 if n2 < n1 else n1;

menor += 1;
soma = 0;
while (menor < maior):
    if(menor % 2 )!=0:
        soma += menor
    menor += 1;
print(soma)

