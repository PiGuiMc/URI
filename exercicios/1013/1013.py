linha = input().split();

A = int(linha[0]);

B = int(linha[1]);

C = int(linha[2]);

MaiorAB = ((A + B) + abs(A - B ))/2;

MaiorABC = ((MaiorAB + C) + abs(MaiorAB - C))/2

print(round(MaiorABC), 'eh o maior');
