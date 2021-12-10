valid = True
qt_turista_saida = 0
qt_turista_volta = 0
qt_jipe = 0
total = 0
while valid:

    n = input().split()
    op = str(n[0])
        
    if op == 'ABEND':
        print(total)
        print(qt_jipe)

        valid = False

    if op == 'SALIDA':
        q = int(n[1])
        qt_turista_saida += q
        qt_jipe += 1
    elif op == 'VUELTA':
        q = int(n[1])
        qt_turista_volta += q
        qt_jipe -= 1

    if qt_turista_saida > qt_turista_volta:
        total = qt_turista_saida - qt_turista_volta