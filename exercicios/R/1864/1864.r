input = file('stdin','r')

n = as.integer(readLines(input,n=1))

frase = "LIFE IS NOT A PROBLEM TO BE SOLVED";

write(sprintf(substr(frase,1,n)),'')