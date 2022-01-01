checked = 0
mediaChecked = 127
null = 255
while True:
    qt = int(input())
    if qt == 0:
        break
    for i in range(qt):
        a,b,c,d,e = map(int,input().split())

        if a >= checked and a <= mediaChecked and b >= mediaChecked and b <= null and c >= mediaChecked and c <= null and d >= mediaChecked and d <= null and e >= mediaChecked and e <= null:
            print('A')
        
        elif a >= mediaChecked and a <= null and b >= checked and b <= mediaChecked and c >= mediaChecked and c <= null and d >= mediaChecked and d <= null and e >= mediaChecked and e <= null:
            print('B')

        elif a >= mediaChecked and a <= null and b >= mediaChecked and b <= null and c >= checked and c <= mediaChecked and d >= mediaChecked and d <= null and e >= mediaChecked and e <= null:
            print('C')
        
        elif a >= mediaChecked and a <= null and b >= mediaChecked and b <= null and c >= mediaChecked and c <= null and d >= checked and d <= mediaChecked and e >= mediaChecked and e <= null:
            print('D')
        
        elif a >= mediaChecked and a <= null and b >= mediaChecked and b <= null and c >= mediaChecked and c <= null and d >= mediaChecked and d <= null and e >= checked and e <= mediaChecked:
            print('E')
        else:
            print('*')