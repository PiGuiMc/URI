var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n')

var valid = true;
while(valid == true){
    var cont =0;
    var nota=0; 
    while(cont<2){
        
       var n = parseFloat(lines.shift());

        if(n < 0 || n > 10){
            console.log("nota invalida");
        }else if(n >=0 && n <=10){
            nota += n;
            cont +=1;
        }     
    }
    console.log("media =",(nota/2).toFixed(2));
    if(cont ==2){
        cont = 0;
        nota = 0;
    }

     while(true){
        console.log("novo calculo (1-sim 2-nao)");
        var op = parseInt(lines.shift());
        cont = 0;
        if(op==2){
            valid = false;
            break;
        }else if(op == 1){
            valid = true;
            cont = 0;
            nota =0;
            break;
        }
    }
}