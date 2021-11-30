def cha():
    vchar = int(input())
    return(vchar)

def competidor(vchar):
  
    qt = 0
  
    v = input()
    v = v.split(' ')

    for i in range(5):
        if int(v[i]) == vchar:
            qt += 1
        i += 1
    return(qt)

def main():
    qt = competidor(cha())

    print(qt)

main()