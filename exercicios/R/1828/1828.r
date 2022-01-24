input = file('stdin','r')

n = as.integer(readLines(input,n=1))
i = as.integer(1)
while(i<=n){
    line = strsplit(readLines(input,n=1), " ")
    s1 = line[[1]][1]
    s2 = line[[1]][2]

    if(s1==s2){write(sprintf("Caso #%d: De novo!",i),'')}
    else if(s1 == "tesoura" && s2 == "papel"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if(s2 == "tesoura" && s1 == "papel"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "papel" && s2 == "pedra"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "papel" && s1 == "pedra"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "pedra" && s2 == "lagarto"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "pedra" && s1 == "lagarto"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "lagarto" && s2 == "Spock"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "lagarto" && s1 == "Spock"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "Spock" && s2 == "tesoura"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "Spock" && s1 == "tesoura"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "tesoura" && s2 == "lagarto"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "tesoura" && s1 == "lagarto"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "lagarto" && s2 == "papel"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "lagarto" && s1 == "papel"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "papel" && s2 == "Spock"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "papel" && s1 == "Spock"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "Spock" && s2 == "pedra"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "Spock" && s1 == "pedra"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
                else if (s1 == "pedra" && s2 == "tesoura"){write(sprintf("Caso #%d: Bazinga!",i),'')}
                else if (s2 == "pedra" && s1 == "tesoura"){write(sprintf("Caso #%d: Raj trapaceou!",i),'')}
    i=i+1
}