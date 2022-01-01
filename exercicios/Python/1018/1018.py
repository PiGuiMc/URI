vl = int(input());

print(vl);

cedulas =[100, 50, 20, 10, 5, 2, 1]

for cedula in cedulas:
    qt_cedulas = int(vl / cedula);

    print("{} nota(s) de R$ {},00".format(qt_cedulas,cedula));
    vl -= qt_cedulas* cedula;
