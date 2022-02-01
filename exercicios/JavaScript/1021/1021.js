var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

const nota = [100.00, 50.00, 20.00, 10.00, 5.00, 2.00]
const moeda = [1.00, 0.50, 0.25, 0.10, 0.05, 0.01]

var valor = parseFloat(lines.shift())

var qt = 0, qt_m=0;

console.log("NOTAS:")
nota.forEach(nota => {
    qt = Math.abs(valor / nota)
    qt = qt - qt%1;

    valor = valor - (qt * nota);

    console.log(qt + " nota(s) de R$ " + nota.toFixed(2));
});

console.log("MOEDAS:")
moeda.forEach(moeda => {
    qt_m = Math.abs((valor / moeda) + 0.0001)
    qt_m = qt_m - qt_m%1

    valor = valor - (qt_m * moeda)
    console.log(qt_m + " moeda(s) de R$ " + moeda.toFixed(2));
});