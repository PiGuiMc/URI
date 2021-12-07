vit_c_min = 110
vit_c_max = 130
total = 0
while True:
    t = int(input())

    if t == 0:
        break

    for i in range(t):
        
        v = input().split()

        qt = int(v[0])
        op = ' '.join(v[1:])

        if op == 'suco de laranja':
            total += 120 * qt

        elif op == 'morango freco':
            total += 85 * qt
        
        elif op == 'mamao':
            total += 85 * qt

        elif op == 'goiaba vermelha':
            total += 70 * qt

        elif op == 'manga':
            total += 56 * qt
        
        elif op == 'laranja':
            total += 50 * qt

        elif op == 'brocolis':
            total += 34 * qt

    if total >= vit_c_min and total <= vit_c_max:
        print(total,'mg')
        total = 0
        continue

    elif total > vit_c_max:
        diminuir = total - vit_c_max
        print('Menos {} mg'.format(diminuir))
        total = 0
        continue

    elif total < vit_c_min:
        aumentar = vit_c_min - total
        print('Mais {} mg'.format(aumentar))
        total = 0
        continue