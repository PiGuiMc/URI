a = 1;
b = 2;
c = 3;
i = 0;

while i <= 2.0:
    if i == 0 or i == 1 or i > 1.8 :
        print('I={:.0f}'.format(i),'J={:.0f}'.format(a))
        print('I={:.0f}'.format(i),'J={:.0f}'.format(b))
        print('I={:.0f}'.format(i),'J={:.0f}'.format(c))
        
    else:   
        print('I={:.1f}'.format(i),'J={:.1f}'.format(a))
        print('I={:.1f}'.format(i),'J={:.1f}'.format(b))
        print('I={:.1f}'.format(i),'J={:.1f}'.format(c))
    a += 0.2
    b += 0.2
    c += 0.2
    i += 0.2