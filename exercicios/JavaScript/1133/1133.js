var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = parseInt(lines.shift());
var y = parseInt(lines.shift());

var menor = x<y ? x : y;
var maior = x>y ? x : y;

for(let i=menor+1;i<maior; i++){
    if(i%5==2 || i%5==3){
        console.log(i);
    }
}