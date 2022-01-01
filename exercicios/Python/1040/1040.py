ns = (input('')).split()
a = float(ns[0])
b = float(ns[1])
c = float(ns[2])
d = float(ns[3])
m = ((a * 2) + (b * 3) + (c * 4) + (d)) / 10
print('Media: {:.1f}'.format(m))
if m >= 7.0:
    print('Aluno aprovado.')
elif m < 5.0:
    print('Aluno reprovado.')
elif m >= 5.0 and m <= 6.9:
    print('Aluno em exame.')
    ne = float(input(''))
    print('Nota do exame: {:.1f}'.format(ne))
    m = (ne + m) / 2
    if m >= 5.0:
        print('Aluno aprovado.')
    elif m <= 4.9:
        print('Aluno reprovado.')
    print('Media final: {:.1f}'.format(m))