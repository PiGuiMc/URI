opcoes = {0:'PROXYCITY',1:'P.Y.N.G.',2:'DNSUEY!',3:'SERVERS',4:'HOST!',5:'CRIPTONIZE',6:'OFFLINE DAY',7:'SALT',8:'ANSWER!',9:'RAR?',10:'WIFI ANTENNAS'}
n = int(input())

for i in range(n):
    v = input().split()
    n1 = int(v[0])
    n2 = int(v[1])

    op = n1 + n2
    print(opcoes[op])

