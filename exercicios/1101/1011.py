x = input().split()
a, b = x
a = int(a)
b = int(b)

num1 = 0
num2 = 0
cond = True
aux = 0

while cond:
    if a > b:
        num1 = b
        num2 = a
    else:
        num1 = a
        num2 = b

    if(num1 <= 0 or num2 <= 0):
        break

    if num2 > num1 :
        aux = num2
        num2 = num1
        num1 = aux
               
        soma = 0
while num2 <= num1 :
         print(num2, end=' ')
         soma += num2
         num2+=1
         print("Sum=%d"%soma)

