input = file('stdin','r')

unidade = as.integer(0)
dezena = as.integer(0)
centena = as.integer(0)

n = as.integer(readLines(input,n=1))
roma = ""

unidade = n%%10;

n = n / 10;

dezena = (n%%10 - n%%1);

n = n / 10;

centena = (n%%10 - n%%1);

if(centena>0){
    if(centena <= 3){
        if(centena == 1){
            roma = paste(roma,"C",sep="")
        }else if(centena == 2){
            roma = paste(roma,"CC",sep="")
        }else if(centena == 3){
            roma = paste(roma,"CCC",sep="")}           
    }else if(centena == 4){
        roma = paste(roma,"CD",sep="")
    }else if(centena == 5){
        roma = paste(roma,"D",sep="")
    }else if(centena > 5 && centena < 9){
        if(centena == 6){
            roma = paste(roma,"DC",sep="")
        }else if(centena == 7){
            roma = paste(roma,"DCC",sep="")
        }else if(centena == 8){
            roma = paste(roma,"DCCC",sep="")}
    }
    else if(centena == 9){
            roma = paste(roma,"CM",sep="")
    }
}
if(dezena > 0){
    if(dezena <= 3){
        if(dezena == 1){
            roma = paste(roma,"X",sep="")
        }else if(dezena == 2){
            roma = paste(roma,"XX",sep="")
        }else if(dezena == 3){
            roma = paste(roma,"XXX",sep="")} 
        }else if(dezena == 4){
            roma = paste(roma,"XL",sep="")
        }else if(dezena == 5){
            roma = paste(roma,"L",sep="")
        }else if(dezena > 5 && dezena < 9){
            if(dezena == 6){
                roma = paste(roma,"LX",sep="")
            }else if(dezena == 7){
                roma = paste(roma,"LXX",sep="")
            }else if(dezena == 8){
                roma = paste(roma,"LXXX",sep="")}
        }
        else if(dezena == 9){
            roma = paste(roma,"XC",sep="")
            }   
}
if(unidade > 0){
    if(unidade <= 3){
        if(unidade == 1){
            roma = paste(roma,"I",sep="")
        }else if(unidade == 2){
            roma = paste(roma,"II",sep="")
        }else if(unidade == 3){
            roma = paste(roma,"III",sep="")} 
        }else if(unidade == 4){
            roma = paste(roma,"IV",sep="")
        }else if(unidade == 5){
            roma = paste(roma,"V",sep="")
        }else if(unidade > 5 && unidade < 9){
            if(unidade == 6){
                roma = paste(roma,"VI",sep="")
            }else if(unidade == 7){
                roma = paste(roma,"VII",sep="")
            }else if(unidade == 8){
                roma = paste(roma,"VIII",sep="");}
            }
        else if(unidade == 9){
            roma = paste(roma,"IX",sep="")
        }
}

write(roma,'')