'''
1 h = 15°
1° = 4 min
60 s = 0,06
1h = 60 / 4 = 15°
'''
bd = 'Bom Dia!!'
bt = 'Boa Tarde!!'
bn = 'Boa Noite!!'
dm = 'De Madrugada!!'
h = 0
while True:
    try:

        m = float(input())

        
        total_seg = (240 * m) / 60

        seg = (total_seg % 1) * 60
        min = total_seg
        #print(min)
        t = m - (m % 1)

        if t >= 0 and t < 15:
            h = 6
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('0%d:%d:%d'%(h,min,seg))
        
        if t >= 15 and t < 30:
            min = min - 60
            h = 7
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('0%d:%d:%d'%(h,min,seg))


        if t >= 30 and t < 45:
            min = min - (60 * 2)
            h = 8
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('0%d:%d:%d'%(h,min,seg))

        if t >= 45 and t < 60:
            min = min - (60 * 3)
            h = 9
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('0%d:%d:%d'%(h,min,seg))

        if t >= 60 and t < 75:
            min = min - (60 * 4)
            h = 10
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('%d:%d:%d'%(h,min,seg))

        if t >= 75 and t < 90:
            min = min - (60 * 5)
            h = 11
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('%d:%d:%d'%(h,min,seg))

        if t >= 90 and t < 105:
            min = min - (60 * 6)
            h = 12
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
            else:
                print(bt)
                print('%d:%d:%d'%(h,min,seg))

        if t >= 105 and t < 120:
            min = min - (60 * 7)
            h = 13
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:%d'%(h,min,seg))
            else:
                print(bt)
                print('%d:%d:%d'%(h,min,seg))

        if t >= 120 and t < 135:
            min = min - (60 * 8)
            h = 14
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:%d'%(h,min,seg))
            else:
                print(bt)
                print('%d:%d:%d'%(h,min,seg))

        if t >= 135 and t < 150:
            min = min - (60 * 9)
            h = 15
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:%d'%(h,min,seg))
            else:
                print(bt)
                print('%d:%d:%d'%(h,min,seg))

        if t >= 150 and t < 165:
            min = min - (60 * 10)
            h = 16
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bt)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 165 and t < 180:
            min = min - (60 *11)
            h = 17
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bt)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bt)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bt)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 180 and t < 195:
            min = min - (60 *12)
            h = 18
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bn)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 195 and t < 210:
            min = min - (60 *13)
            h = 19
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bn)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 210 and t < 225:
            min = min - (60 *14)
            h = 20
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bn)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 225 and t < 240:
            min = min - (60 *15)
            h = 21
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bn)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 240 and t < 255:
            min = min - (60 *16)
            h = 22
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bn)
                print('%d:0%d:0%d'%(h,min,seg))
    
        if t >= 255 and t < 270:
            min = min - (60 *17)
            h = 23
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bn)
                    print('%d:%d:0%d'%(h,min,seg))
                else:
                    print(bn)
                    print('%d:0%d:0%d'%(h,min,seg))
            else:
                print(bn)
                print('%d:0%d:0%d'%(h,min,seg))

        if t >= 270 and t < 285:
            min = min - (60 *18)
            h = 0
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            else:
                print(dm)
                print('0%d:0%d:0%d'%(h,min,seg))

        if t >= 285 and t < 300:
            min = min - (60 *19)
            h = 1
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            else:
                print(dm)
                print('0%d:0%d:0%d'%(h,min,seg))

        if t >= 300 and t < 315:
            min = min - (60 *20)
            h = 2
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            else:
                print(dm)
                print('0%d:0%d:0%d'%(h,min,seg))

        if t >= 315 and t < 330:
            min = min - (60 * 21)
            h = 3
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            else:
                print(dm)
                print('0%d:0%d:0%d'%(h,min,seg))

        if t >= 330 and t < 345:
            min = min - (60 * 22)
            h = 4
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            else:
                print(dm)
                print('0%d:0%d:0%d'%(h,min,seg))

        if t >= 345 and t < 360:
            min = min - (60 *23)
            h = 5
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(dm)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(dm)
                    print('0%d:0%d:0%d'%(h,min,seg))
            else:
                print(dm)
                print('0%d:0%d:0%d'%(h,min,seg))

        if t == 360:
            min = min - (60 *24)
            h = 6
            if min >= 0 and min < 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:0%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:0%d:%d'%(h,min,seg))
            elif min >= 10:
                if seg >= 0 and seg < 10:
                    print(bd)
                    print('0%d:%d:0%d'%(h,min,seg))
                else:
                    print(bd)
                    print('0%d:%d:%d'%(h,min,seg))
            else:
                print(bd)
                print('0%d:%d:%d'%(h,min,seg))
        #print('min', min)
        #print('seg',(seg))
        #print('h',t)


    except EOFError:
        break