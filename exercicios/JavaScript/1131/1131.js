const { Console } = require('console');

var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var count=0, g_gre=0, g_int=0, emp=0;

while(true){
    var line1 =  lines.shift().split(' ');
    var gol_int = parseInt(line1[0]), gol_gre = parseInt(line1[1]);

    if(gol_int > gol_gre){
        g_int += 1;
    }else if( gol_int < gol_gre){
        g_gre += 1;
    }else{
        emp += 1;
    }
    count += 1;

    console.log("Novo grenal (1-sim 2-nao)")
    
    var new_placar = parseInt(lines.shift());

    if(new_placar == 2){
        console.log(count+ " grenais");
        console.log("Inter:"+ g_int);
        console.log("Gremio:"+ g_gre);
        console.log("Empates:"+emp);

        if(g_int > g_gre){
            console.log("Inter venceu mais");
        }else if(g_int < g_gre){
            console.log("Gremio venceu mais");
        }else{
            console.log("Empate");
        }

        break;
    }
}