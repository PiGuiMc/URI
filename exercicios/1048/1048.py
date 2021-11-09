valor = float(input())

if(valor <= 400):
    reaj = 0.15
    sal_reaj = valor + (valor * reaj)
    reaj_ganho = sal_reaj - valor
    p = 15
    print('Novo salario: {:.2F} '.format(sal_reaj))
    print('Reajuste ganho: {:.2F} '.format(reaj_ganho))
    print('Em percentual: {} %'.format(p))

elif(valor >= 400.01) and (valor <= 800):
    reaj = 0.12
    sal_reaj = valor + (valor * reaj)
    reaj_ganho = sal_reaj - valor
    p = 12
    print('Novo salario: {:.2F} '.format(sal_reaj))
    print('Reajuste ganho: {:.2F} '.format(reaj_ganho))
    print('Em percentual: {} %'.format(p))

elif(valor >= 800.01) and (valor <= 1200):
    reaj = 0.10
    sal_reaj = valor + (valor * reaj)
    reaj_ganho = sal_reaj - valor
    p = 10
    print('Novo salario: {:.2F} '.format(sal_reaj))
    print('Reajuste ganho: {:.2F} '.format(reaj_ganho))
    print('Em percentual: {} %'.format(p))

elif(valor >= 1200.01) and (valor <= 2000):
    reaj = 0.07
    sal_reaj = valor + (valor * reaj)
    reaj_ganho = sal_reaj - valor
    p = 7
    print('Novo salario: {:.2F} '.format(sal_reaj))
    print('Reajuste ganho: {:.2F} '.format(reaj_ganho))
    print('Em percentual: {} %'.format(p))

elif(valor >= 2000):
    reaj = 0.04
    sal_reaj = valor + (valor * reaj)
    reaj_ganho = sal_reaj - valor
    p = 4
    print('Novo salario: {:.2F} '.format(sal_reaj))
    print('Reajuste ganho: {:.2F} '.format(reaj_ganho))
    print('Em percentual: {} %'.format(p))