from math import trunc

while True:
    line = input()
    if line == '0 0 0':
        break
    dimensions = list(map(int, line.split()))
    volume = 1
    for a in dimensions:
        volume*=a
    print(trunc(volume**(1/3)))
