while(True):
    try:
        p = input()

        print('palavrao') if(len(p) >= 10) else print('palavrinha')
        
    except EOFError:
        break