var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var Valor = parseFloat(lines.shift());

var i8 = 0, i18 = 0, i28 = 0, vimp = 0;

if(Valor >= 0 && Valor <= 2000)
{
    console.log("Isento");
}

else if(Valor >= 2000.01 && Valor <= 3000)
{
    vimp = (Valor - 2000) * 0.08;
    console.log("R$ " + vimp.toFixed(2));
}
else if(Valor >= 3000.01 && Valor <= 4500)
{
    i8 = 0.08 * 1000;
    i18 = (Valor - 3000);
    vimp = (i18 * 0.18) + i8;
    console.log("R$ " + vimp.toFixed(2));
}
else if(Valor >= 4500.01)
{
    i8 = 0.08* 1000;
    i18 = 0.18 * 1500;
    i28 = Valor - 4500;
    vimp = i18 + i8 + (i28 * 0.28);
    console.log("R$ " + vimp.toFixed(2));
}