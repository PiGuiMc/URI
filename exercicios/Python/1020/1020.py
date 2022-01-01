dias = int(input());

anos = int(dias / 365);
saldo = dias - anos * 365;

meses = int(saldo / 30);
dias = saldo - meses * 30;

print('{} ano(s)'.format(anos));
print('{} mes(es)'.format(meses));
print('{} dia(s)'.format(dias));