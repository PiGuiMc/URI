var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var n = parseInt(line1[0]), qt = parseInt(line1[1]), count =1;
var teste = []

for(let i=1; i<=qt; i++){
    
    teste.push(i);
    if(count == n){
        console.log(teste.join(' '));
        count = 1;
        teste = []
    }else{
        count ++;
    }
}