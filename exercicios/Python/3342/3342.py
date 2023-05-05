n = int(input())

b, p = 0,0

t = n*n

for i in range(t):
    if(i%2 == 0):
        b +=1

    elif(i%2 != 0):
        p+=1
print(f'{b} casas brancas e {p} casas pretas')