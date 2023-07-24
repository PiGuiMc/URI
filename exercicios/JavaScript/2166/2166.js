var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n')

//precisa corrigir!
var res = parseFloat(0);
var v = parseInt(lines.shift())

for(let i=0;i<v;i++){
    if(v=0){
        res = 2
    }
    res += 2 + 1/(i+1)
}

console.log(res)