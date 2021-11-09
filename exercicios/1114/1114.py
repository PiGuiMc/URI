x = 0;
senha = 2002;

while x != senha:
    x = int(input())

    if x == senha:
        print('Acesso Permitido')
        exit;
    if x != senha:
        print('Senha Invalida')
