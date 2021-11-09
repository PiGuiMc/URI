entrada = input().split();

cod = int(entrada[0])
qt = int(entrada[1])

if(cod == 1):
    vl = float(4.0 * qt)
elif(cod == 2):
    vl = float(4.5 * qt)
elif(cod == 3):
    vl = float(5 * qt)
elif(cod == 4):
    vl =float(2 * qt)
elif(cod == 5):
    vl = float(1.5 * qt)
print("Total: R$ {:.2F}".format(vl))