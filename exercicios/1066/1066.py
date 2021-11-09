a = [];
for i in range(5):
    n = int(input());
    a.append(int(n));

par = 0;
imp = 0;
pos = 0;
neg = 0;
for j in range(5):
    
    if (a[j] % 2) == 0:
        par = par + 1;

    if (a[j] % 2) == 1:
        imp = imp + 1;

    if a[j] > 0:
        pos = pos + 1;
    
    if a[j] < 0:
        neg = neg + 1;

print(par, 'valor(es) par(es)')
print(imp, 'valor(es) impar(es)')
print(pos, 'valor(es) positivo(s)')
print(neg, 'valor(es) negativo(s)')
