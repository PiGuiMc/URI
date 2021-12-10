rena = {1:'Dasher', 2:'Dancer', 3:'Prancer', 4:'Vixen', 5:'Comet', 6:'Cupid', 7:'Donner', 8:'Blitzen', 0:'Rudolph'}

teste = sum(map(int,input().split()))

dec = int((teste % 9) )
print(rena[dec])