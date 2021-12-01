while 1:
    try:
        pi = 3.14
        
        volume = float(input())
        diametro = float(input())

        raio =  (diametro / 2)
        area = pi * raio**2

        altura = volume / area

        print('ALTURA = {:.2f}'.format(altura))
        print('AREA = {:.2F}'.format(area))
    except:
        break
