var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var n = parseInt(lines.shift()), soma = 0;

    if(n == 0){
        break;
    }else{
        for(let i=n; i<n+10; i++){
            if(i % 2 == 0){
                soma += i;
            }
        }
        console.log(soma)
    }
}