while 1:
    try:
        pi = 3.14
        
        v = int(input())
        d = int(input())

        teste = pi * (d/2)
        altura = v / teste

        area =  v / altura

        print('ALTURA = {:.2f}'.format(altura))
        print('AREA = {:.2F}'.format(area))
    except:
        break
