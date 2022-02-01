var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

const itens = [365, 30, 1]
var qt = 0;
var valor = parseInt(lines.shift());

itens.forEach(itens => {
    qt = Math.abs(valor / itens);

    qt = qt - qt%1;

    valor = valor - (qt * itens);

    if(itens == 365){
        console.log(qt + " ano(s)")
    }else if(itens == 30){
        console.log(qt + " mes(es)")
    }else if(itens == 1){
        console.log(qt + " dia(s)")
    }
});
