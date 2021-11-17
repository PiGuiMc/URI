n = input().split()

t1 = int(n[0])
t2 = int(n[1])
t3 = int(n[2])
t4 = int(n[3])
T = 0

if t1 > 0:
    t1 = t1 - 1

if t2 > 0:
    t2 = t2 - 1
    t1_2 = t2 + t1

if t3 > 0:
    t3 = t3 - 1
    t1_2_3 = t1_2 + t3

if t4 > 0:
    T = t4 + t1_2_3

print(T)
