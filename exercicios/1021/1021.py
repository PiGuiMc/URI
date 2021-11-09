valor =  float(input())

notas = [100, 50, 20, 10, 5, 2]
moedas = [1, 0.50, 0.25, 0.10, 0.05, 0.01]

print("NOTAS")

for nota in notas:
    qt_nota = int(valor / nota)

    print("{} nota(s) de R$ {}.00".format(qt_nota,nota));
    valor -= qt_nota * nota

print("MOEDAS")

for moeda in moedas:
    qt_moeda = int(round(valor,2) / moeda)

    print("{} moeda(s) de R$ {:.2f}".format(qt_moeda,moeda))
    valor -= qt_moeda * moeda