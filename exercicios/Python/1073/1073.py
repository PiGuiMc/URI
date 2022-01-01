n = int(input())
elev = 0;
i = 1
while i <= n:

    if (i % 2) == 0:
        elev = i ** 2
        print("{}^2 = {}".format(i,elev))
    i = i + 1;