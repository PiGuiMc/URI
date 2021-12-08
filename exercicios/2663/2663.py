n = int(input())
min = int(input())
lista = [int(input()) for x in range(n)]
lista.sort(reverse=True)
count = min

while count < n and lista[count] == lista[min-1]:
    count+=1

print(count)