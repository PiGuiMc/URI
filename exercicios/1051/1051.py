valor = float(input())

if(valor <= 2000):
    print("Isento")

elif(valor >= 2000.01) and (valor <= 3000):
    v_imp = (valor - 2000) * 0.08
    print("R$ {:.2F}".format(v_imp))

elif(valor >= 3000.01) and (valor <= 4500):
    i8 = (8 / 100) * 1000
    v_18 = (valor - 3000)
    i = v_18 * (18/100) + i8
    print("R$ {:.2F}".format(i))

elif(valor >= 4500):
    i8 = (8 / 100) * 1000
    i18 = (18/100) * 1500
    r28 = valor - 4500
    i = i18 + i8 + r28 * (28 / 100)
    print("R$ {:.2F}".format(i))

elif(valor < 2000):
    print("R$ {:.2F}".format(valor))