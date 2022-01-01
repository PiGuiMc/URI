x1 = input()
x2 = input()
x3 = input()

if(x1 == "vertebrado"):
    if(x2 == "ave"):
        if(x3 == "carnivoro"):
            print("aguia")

        elif(x3 == "onivoro"):
            print("pomba")
    
    elif(x2 == "mamifero"):
        if(x3 == "onivoro"):
            print("homem")

        elif(x3 == "herbivoro"):
            print("vaca")

elif(x1 == "invertebrado"):
    if(x2 == "inseto"):
        if(x3 == "hematofago"):
            print("pulga")

        elif(x3 == "herbivoro"):
            print("lagarta")
    
    elif(x2 == "anelideo"):
        if(x3 == "hematofago"):
            print("sanguessuga")

        elif(x3 == "onivoro"):
            print("minhoca")