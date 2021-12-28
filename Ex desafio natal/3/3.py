#moedas = [0.5,0.25,0.1,0.05,0.01]
m1,m2,m3,m4,m5 =0,0,0,0,0
n = float(input())
m = float(input())

troco = round(((m - n) % 1),2)

while round(troco,2) > 0:
    if troco - 0.5 >= 0:
        m1+=1
        troco -= 0.5
        troco = round(troco,2)    
    elif troco - 0.25 >= 0:
        m2 += 1
        troco -= 0.25
        troco = round(troco,2)    
    
    elif troco - 0.10 >= 0:
        m3 += 1
        troco -= 0.10
        troco = round(troco,2)   
    
    elif troco - 0.05 >= 0:
        m4 += 1
        troco -= 0.05
        troco = round(troco,2)

    elif troco - 0.01 >= 0:
        m5 += 1
        troco -= 0.01
        troco = round(troco,2)

print('{} moeda(s) de 50'.format(m1))
print('{} moeda(s) de 25'.format(m2))
print('{} moeda(s) de 10'.format(m3))
print('{} moeda(s) de 5'.format(m4))
print('{} moeda(s) de 1'.format(m5))