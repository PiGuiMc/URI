nomes = []
pedidos = []
c = []
while True:
        nome,pedido = input().split()
        nomes.append(nome)
        pedidos.append(pedido)

        if nome == '--' and pedido == '--':
            break
   
while True:
    try:
        child = input()
        c.append(child)
                   
    except EOFError:
            break

for i in range(len(c)):
                        
    if c[i] in nomes:
        print('Child:',c[i])
        n_pos = nomes.index(c[i])
        print('Gift',pedidos[n_pos])
        print('')
    else:  
        print('404 not found')
        print('')
