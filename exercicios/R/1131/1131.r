input = file('stdin','r')

grenais = as.integer(0)
g_inter = as.integer(0)
g_gremio = as.integer(0)
emp = as.integer(0)
cont = as.integer(0)
op = as.integer(0)

while(TRUE){

    line = strsplit(readLines(input,n=1), " ")
    g_i = as.integer(line[[1]][1])
    g_g = as.integer(line[[1]][2])

    if(g_i > g_g){
        g_inter = g_inter + 1
    }else if ( g_i < g_g){
        g_gremio = g_gremio + 1
    }else{
        emp = emp + 1
    }

    cont = cont + 1
    
    write("Novo grenal (1-sim 2-nao)",'')
    op = readLines(input,n=1)

    if(op == 2){
        write(sprintf("%d grenais",cont),'')
        write(sprintf("Inter:%d",g_inter),'')
        write(sprintf("Gremio:%d",g_gremio),'')
        write(sprintf("Empates:%d",emp),'')

        if(g_inter > g_gremio){
            write("Inter venceu mais",'')
        }else if(g_inter < g_gremio){
            write("Gremio venceu mais",'')
        }
        break
    }
}