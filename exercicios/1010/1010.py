linha = input().split();

cod_1 = int(linha[0]);

num_1 = int(linha[1]);

vl_1 = float(linha[2]);

linha2 = input().split();
cod_2 = int(linha2[0]);

num_2 = int(linha2[1]);

vl_2 = float(linha2[2]);

vl_total = ((num_1 * vl_1) + (num_2 * vl_2));

print('VALOR A PAGAR: R$ %.2F' % vl_total);