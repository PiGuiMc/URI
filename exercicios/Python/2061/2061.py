def entrada():
    x = input().split()
    aba = int(x[0])
    qt = int(x[1])
    return aba,qt

def main():
    aba,qt = entrada()

    for i in range(qt):
        o = input()
        if o == 'fechou':
            aba += 1
        
        if o == 'clicou':
            aba -= 1
   
    print(aba)
    
main()