input = file('stdin','r')

Entrada = (readLines(input,n=1))
Entrada1 = (readLines(input,n=1))
Entrada2 = (readLines(input,n=1))

if(Entrada == "vertebrado"){
    if (Entrada1 == "ave"){
        if (Entrada2 == "carnivoro"){
                write(sprintf("aguia"),'')
            }else if (Entrada2 == "onivoro"){
                write(sprintf("pomba"),'')
            }
        }else if (Entrada1 == "mamifero")
            {
                if (Entrada2 == "onivoro"){
                    write(sprintf("homem"),'')
                 }else if( Entrada2 == "herbivoro"){
                    write(sprintf("vaca"),'')
                }
            }
}else if(Entrada == "invertebrado"){
    if (Entrada1 == "inseto"){
        if (Entrada2 == "hematofago"){
            write(sprintf("pulga"),'')
        }else if (Entrada2 == "herbivoro"){
            write(sprintf("lagarta"),'')}
    }else if (Entrada1 == "anelideo"){
        if (Entrada2 == "hematofago"){
            write(sprintf("sanguessuga"),'')
        }else if( Entrada2 == "onivoro"){
            write(sprintf("minhoca"),'')
            }
        }
}