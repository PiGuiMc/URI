var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

let notas = [100, 50, 20, 10, 5, 2, 1]

var valor = parseInt(lines.shift());

console.log(valor);

notas.forEach(notas => {
    qt = Math.abs(valor / notas);
    qt = qt - qt%1;
    valor -= (notas * qt);
    console.log(qt + " nota(s) de R$ " + notas + ",00")
});
