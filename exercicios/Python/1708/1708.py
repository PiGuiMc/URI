import math

p1,p2 = map(int,input().split())

x = p2 - p1

volta = math.ceil(p2/x)

print(volta)