var input = require('fs').readFileSync('stdin','utf-8');
var lines = input.split('\n');

var p = parseInt(lines.shift())
var total = 0

for(let i=0;i<p;i++){
    var valores = lines.shift().split(' ')
    var pedido = valores[0]
    var qt = parseInt(valores[1])

    if(pedido == 1001){
        total += qt * 1.50;
    }else if(pedido == 1002){
        total += qt * 2.50
    }else if(pedido == 1003){
        total += qt * 3.50
    }else if(pedido == 1004){
        total += qt * 4.50
    }else if(pedido == 1005){
        total += qt * 5.50
    }
}
console.log(parseFloat(total).toFixed(2))