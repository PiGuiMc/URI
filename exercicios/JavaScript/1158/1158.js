var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var line1 = lines.shift().split(' ');

    var x = parseInt(line1[0]), y = parseInt(line1[1]),j=1,soma=0;

    while(j<=y){
        if(x%2 !=0){
            soma = soma + x;

            x = x + 1;
            j = j +1;
        }
        if(x%2==0){
            x = x + 1;
        }
    }
    console.log(soma);
}