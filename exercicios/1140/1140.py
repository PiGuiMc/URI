while True:

    n = input()

    if n == '*':
        break

    n = n.split(" ")
    var = 0

    for i in range(len(n)-1):
        if (n[i][:1].lower() == n[i+1][:1].lower()):
            var +=1
        
        else:
            var = 0
    if var >= 1:
        print('Y')
    else:
        print('N')
