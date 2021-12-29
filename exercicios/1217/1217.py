valor,qt_d,qt_frutas = 0,0,0

n = int(input())

for i in range(n):
    p = 0
    v = float(input())
    valor += v
    frutas = [str(x) for x in input().split()]

    p += len(frutas)
    qt_frutas += p

    qt_d += 1
    
    print('day {}: {} kg'.format((i+1),p))

m_p = qt_frutas/qt_d
m_v = valor/qt_d
print('{:.2f} kg by day'.format(m_p))
print('R$ {:.2f} by day'.format(m_v))