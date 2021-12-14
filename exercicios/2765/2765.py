n = str(input())

vir =  n.rfind(',')
pos = vir + 1
text1 = n[0:vir]
text2 = n[pos:len(n)]
print(text1)
print(text2)