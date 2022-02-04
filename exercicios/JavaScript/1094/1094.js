var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var n = parseInt(lines.shift());

var r = 0, c = 0, s = 0, total = 0;

for(let i=1; i<=n; i++){
    var line1 = lines.shift().split(' ');

    var qt = parseInt(line1[0]);
    var op = String(line1[1]);
  
    if(op == 'C\r' || op == 'C'){
        c += qt;
    }else if(op == 'R\r' || op == 'R'){
        r += qt;
    }else if(op == 'S\r' || op =='S'){
        s += qt;
    }

    total += qt;
}

console.log("Total: " + total + " cobaias");
console.log("Total de coelhos: " + c);
console.log("Total de ratos: " + r);
console.log("Total de sapos: " + s);
console.log("Percentual de coelhos: " + ((c*100)/total).toFixed(2) + " %");
console.log("Percentual de ratos: " + ((r*100)/total).toFixed(2) + " %");
console.log("Percentual de sapos: " + ((s*100)/total).toFixed(2) + " %");