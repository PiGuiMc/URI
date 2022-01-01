linha = input().split();

A = float(linha[0]);

B = float(linha[1]);

C = float(linha[2]);

pi = 3.14159;

triang = (A * C)/2;

circ = pi * (C*C);

trap = ((A + B) / 2) * C;

quad = B * B;

ret = A * B;

print('TRIANGULO: %.3F' % triang);
print('CIRCULO: %.3F' % circ);
print('TRAPEZIO: %.3F' % trap);
print('QUADRADO: %.3F' % quad);
print('RETANGULO: %.3F' % ret);

