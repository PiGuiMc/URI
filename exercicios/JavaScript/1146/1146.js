var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var list = [];
    var n = parseInt(lines.shift());
    if(n == 0){
        break;
    }else{ 
        for(let i=1; i<=n; i++){
            list.push(i);
        }
        console.log(list.join(' '));
        list = [];
    }
}