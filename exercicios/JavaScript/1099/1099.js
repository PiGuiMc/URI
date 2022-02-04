var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var maior=0, menor=0, s=0;
    var line1 = lines.shift().split(' ');

    var x = parseInt(line1[0]);
    var y = parseInt(line1[1]);

    if(x > y){
        maior = x;
        menor = y;
    }else{
        maior = y;
        menor = x;
    }

    for(let j=menor+1; j < maior; j++){
        if(j % 2 !==0){
            s += j;
        }
    }

    if(x == y){
        s = 0;
    }

    console.log(s);
}